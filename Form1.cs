using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace HashVault
{
    public partial class frmHashVault : Form
    {
        public frmHashVault()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#243545");
            this.ForeColor = Color.White;

            btnBrowse.FlatStyle = btnHash.FlatStyle = btnAppendLog.FlatStyle = btnExport.FlatStyle = FlatStyle.Flat;

            lbltitle.ForeColor = ColorTranslator.FromHtml("#F0F2F5");

            ApplyHoverEffect(btnBrowse, "#4E81AC", "#F0F2F5", "#3AB0A2", "#121C2B");
            ApplyHoverEffect(btnHash, "#4E81AC", "#F0F2F5", "#3AB0A2", "#121C2B");
            ApplyHoverEffect(btnAppendLog, "#4E81AC", "#F0F2F5", "#3AB0A2", "#121C2B");
            ApplyHoverEffect(btnExport, "#4E81AC", "#F0F2F5", "#3AB0A2", "#121C2B");


            //drag & drop
            txtFilePath.AllowDrop = true;
            txtFilePath.DragEnter += txtFilePath_DragEnter;
            txtFilePath.DragDrop += txtFilePath_DragDrop;

            //links
            lblGithub.LinkClicked += LinkLabelGitHub_LinkClicked;


        }
        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/DiodorEos/",
                UseShellExecute = true
            });
        }
        private void LinkLabelLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://spdx.org/licenses/CC-BY-NC-SA-4.0.html",
                UseShellExecute = true
            });
        }

        private void ApplyHoverEffect(Button btn, string normalHexBack, string normalHexFore, string hoverHexBack, string hoverHexFore)
        {
            btn.BackColor = ColorTranslator.FromHtml(normalHexBack);
            btn.MouseLeave += (s, e) => btn.BackColor = ColorTranslator.FromHtml(normalHexBack);
            btn.MouseEnter += (s, e) => btn.BackColor = ColorTranslator.FromHtml(hoverHexBack);
            btn.MouseLeave += (s, e) => btn.ForeColor = ColorTranslator.FromHtml(normalHexFore);
            btn.MouseEnter += (s, e) => btn.ForeColor = ColorTranslator.FromHtml(hoverHexFore);

        }


        private void Form1_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void txtFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                txtFilePath.BackColor = Color.LightYellow;
            }
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtFilePath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && File.Exists(files[0]))
            {
                txtFilePath.Text = files[0];
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a file to hash";
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedAlgorithms = new List<string>();
            if (chkMD5.Checked) selectedAlgorithms.Add("MD5");
            if (chkSHA256.Checked) selectedAlgorithms.Add("SHA256");
            if (chkSHA512.Checked) selectedAlgorithms.Add("SHA512");

            if (selectedAlgorithms.Count == 0)
            {
                MessageBox.Show("Please select at least one hashing method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FileSnapshot snapshot = new FileSnapshot(filePath);
                foreach (var algo in selectedAlgorithms)
                {
                    string hash = HashUtils.ComputeHash(filePath, algo);
                    snapshot.AddHash(algo, hash);
                }
                txtHashOutput.Text = string.Join(Environment.NewLine, snapshot.Hashes.Select(h => $"{h.Key}: {h.Value}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error computing hash: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedAlgorithms = new List<string>();
            if (chkMD5.Checked) selectedAlgorithms.Add("MD5");
            if (chkSHA256.Checked) selectedAlgorithms.Add("SHA256");
            if (chkSHA512.Checked) selectedAlgorithms.Add("SHA512");


            if (selectedAlgorithms.Count == 0)
            {
                MessageBox.Show("Please select at least one hashing method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FileSnapshot snapshot = new FileSnapshot(filePath);
                foreach (var algo in selectedAlgorithms)
                {
                    string hash = HashUtils.ComputeHash(filePath, algo);
                    snapshot.AddHash(algo, hash);
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save hash to file";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FileName = "HashVault_output.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, snapshot.ToString());
                    MessageBox.Show("Hash exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting the hash:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAppendLog_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;

            if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Please select a valid file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedAlgorithms = new List<string>();
            if (chkMD5.Checked) selectedAlgorithms.Add("MD5");
            if (chkSHA256.Checked) selectedAlgorithms.Add("SHA256");
            if (chkSHA512.Checked) selectedAlgorithms.Add("SHA512");

            if (selectedAlgorithms.Count == 0)
            {
                MessageBox.Show("Please select at least one hashing method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FileSnapshot snapshot = new FileSnapshot(filePath);
                foreach (var algo in selectedAlgorithms)
                {
                    string hash = HashUtils.ComputeHash(filePath, algo);
                    snapshot.AddHash(algo, hash);
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Append hash to log file";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.FileName = "HashVault_log.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.AppendAllText(saveFileDialog.FileName, snapshot.ToString() + "\n");
                    MessageBox.Show("Hash appended to log file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while appending the hash:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e) { }
        private void txtFilePath_TextChanged(object sender, EventArgs e) { }

        private void lblLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

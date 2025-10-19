using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileSnapshot
{
    public string FileName { get; set; }
    public string FullPath { get; set; }
    public DateTime Timestamp { get; set; }
    public Dictionary<string, string> Hashes { get; set; } = new();

    public FileSnapshot(string fullPath)
    {
        FullPath = fullPath;
        FileName = Path.GetFileName(fullPath);
        Timestamp = DateTime.Now;
    }

    public void AddHash(string algorithm, string hash)
    {
        Hashes[algorithm] = hash;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Timestamp: {Timestamp:yyyy-MM-dd HH:mm:ss}");
        sb.AppendLine($"File: {FileName}");
        foreach (var kvp in Hashes)
            sb.AppendLine($"{kvp.Key}: {kvp.Value}");
        return sb.ToString();
    }
}

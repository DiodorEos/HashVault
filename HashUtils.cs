using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

public static class HashUtils
{
    public static string ComputeHash(string filePath, string algorithm)
    {
        using (FileStream stream = File.OpenRead(filePath))
        {
            HashAlgorithm hasher = algorithm switch
            {
                "MD5" => MD5.Create(),
                "SHA256" => SHA256.Create(),
                "SHA512" => SHA512.Create(),
                _ => throw new ArgumentException("Unsupported algorithm")
            };

            byte[] hashBytes = hasher.ComputeHash(stream);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }
    }
}
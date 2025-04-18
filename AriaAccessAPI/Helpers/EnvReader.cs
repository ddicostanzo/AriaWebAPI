using System.Reflection;
using System.IO;
using System;
using System.Linq;

public class EnvReader
{
    // private static string location = Directory.GetCurrentDirectory();
    public static void Load(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"The file '{filePath}' does not exist.");

        foreach (var line in File.ReadAllLines(filePath))
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                continue; // Skip empty lines and comments

            var parts = line.Split('=');
            if (parts.Length != 2)
                continue; // Skip lines that are not key-value pairs

            var key = parts[0].Trim();
            var value = parts[1].Trim();
            Environment.SetEnvironmentVariable(key, value);
        }
    }
}

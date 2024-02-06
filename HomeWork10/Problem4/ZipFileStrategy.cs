using System.IO.Compression;

namespace HomeWork10.Problem4;

public class ZipFileStrategy : IFileStrategy
{
    public void Execute(string filePath)
    {
        string backupDirectory = Path.Combine(Path.GetDirectoryName(filePath), "backup");
        Directory.CreateDirectory(backupDirectory);
        ZipFile.ExtractToDirectory(filePath, backupDirectory);
    }
}
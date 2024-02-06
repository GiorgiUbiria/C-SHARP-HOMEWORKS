namespace HomeWork10.Problem4;

public class TxtFileStrategy : IFileStrategy
{
    public void Execute(string filePath)
    {
        File.Delete(filePath);
    }
}
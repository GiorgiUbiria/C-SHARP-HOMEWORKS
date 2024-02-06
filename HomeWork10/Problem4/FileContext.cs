namespace HomeWork10.Problem4;

public class FileContext
{
    private IFileStrategy _strategy;

    public void SetStrategy(IFileStrategy strategy)
    {
        _strategy = strategy;
    }

    public void ExecuteStrategy(string filePath)
    {
        _strategy.Execute(filePath);
    }
}
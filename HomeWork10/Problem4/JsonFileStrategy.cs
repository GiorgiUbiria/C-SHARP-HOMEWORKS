using Newtonsoft.Json;

namespace HomeWork10.Problem4;

public class JsonFileStrategy : IFileStrategy
{
    public void Execute(string filePath)
    {
        string contents = File.ReadAllText(filePath);
        dynamic parsedJson = JsonConvert.DeserializeObject(contents);
        Console.WriteLine(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));
    }
}
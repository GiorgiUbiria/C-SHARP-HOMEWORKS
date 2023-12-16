Console.BackgroundColor = ConsoleColor.Cyan;

string realName = "Giorgi Ubiria";

Console.WriteLine($"Hello {realName}! You are {realName} right?! RIGHT?! Let's check");

Console.Write("Enter your full name: ");

string name = Console.ReadLine()!;

if (realName == name)
{
    Console.ForegroundColor = System.ConsoleColor.Blue;
    Console.WriteLine($"Hello, {name}! I knew it was you.");
}
else
{
    Console.ForegroundColor = System.ConsoleColor.Red;
    Console.WriteLine($"Ooops... Sorry {name}! I thought you were {realName}");
}

Console.ResetColor();
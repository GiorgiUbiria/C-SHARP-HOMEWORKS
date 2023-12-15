#region Problem1
Console.Write("Enter a number: ");
string input;
input = Console.ReadLine();

int number = Convert.ToInt32(input);

if (number % 5 == 0)
{
    Console.WriteLine($"The {number} is divisible by 5!");
}
else
{
    Console.WriteLine($"The {number} is not divisible by 5");
}
#endregion

#region Problem2
string input1, input2;

Console.WriteLine("Enter X: ");
input1 = Console.ReadLine();
Console.WriteLine("Enter Y: ");
input2 = Console.ReadLine();

int number1 = Convert.ToInt32(input1);
int number2 = Convert.ToInt32(input2);

if (number1 < number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}

Console.WriteLine("Switching X and Y");

Console.WriteLine($"X + Y = {number1 + number2}");
Console.WriteLine($"X - Y = {number1 - number2}");
Console.WriteLine($"X * Y = {number1 * number2}");
if (number1 == 0 || number2 == 0)
{
    Console.WriteLine("Cannot divide by 0");
}
else
{
    Console.WriteLine($"X / Y = {number1 / number2}");
}
#endregion

#region Problem3
string fistInput, secondInput;

Console.WriteLine("Input fisrt number: ");
fistInput = Console.ReadLine();
int firstNumber = Convert.ToInt32(fistInput);

Console.WriteLine("Input second number: ");
secondInput = Console.ReadLine();
int secondNumber = Convert.ToInt32(secondInput);

int temporary = firstNumber;
firstNumber = secondNumber;
secondNumber = temporary;

Console.WriteLine($"First number is now {firstNumber} and second number is now {secondNumber}");
#endregion

#region Problem4
Console.WriteLine("Enter the number to print the multiplication table for: ");
string inputToConvert = Console.ReadLine();
int numberToMultiply = Convert.ToInt32(inputToConvert);

for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{numberToMultiply} * {i} = {numberToMultiply * i}");
}
#endregion

#region Problem5
Console.WriteLine("Enter the number greater than 1: ");
string inputToRead = Console.ReadLine();
int numberN = Convert.ToInt32(inputToRead);

for (int i = 2; i <= numberN; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i * i);
    }
    else
    {
        continue;
    }
}
#endregion
#region Problem1
Console.Write("Enter the lower range: ");
int lowerRange = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the higher range: ");
int higherRange = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the power: ");
int power = Convert.ToInt32(Console.ReadLine());

List<int> numbers = FindNumbers(lowerRange, higherRange, power);

Console.WriteLine("The numbers are: ");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"So there are {numbers.Count} elements in the range");

List<int> FindNumbers(int lowerRange, int higherRange, int power)
{
    List<int> numbers = new List<int>();
    for (int i = 1; i <= higherRange; i++)
    {
        double result = Math.Pow(i, power);
        if (result >= lowerRange && result <= higherRange)
        {
            numbers.Add(i);
        }
    }
    return numbers;
}
#endregion
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

#region Problem2
#endregion

#region Problem3
Console.Write("Enter two strings separated by a comma: ");
string input = Console.ReadLine();

string[] words = input.Split(',');

string suffix = FindCommonSuffix(words[0].Trim(), words[1].Trim());

Console.WriteLine($"The longest common end suffix is: {suffix}");

string FindCommonSuffix(string str1, string str2)
{
    int i = str1.Length - 1;
    int j = str2.Length - 1;

    while (i >= 0 && j >= 0 && str1[i] == str2[j])
    {
        i--;
        j--;
    }

    return str1.Substring(i + 1);
}
#endregion

#region Problem4

#endregion
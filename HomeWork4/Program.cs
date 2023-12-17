#region Problem1
int arrSize = 0;
Console.WriteLine("How large do you wish your array to be?");
arrSize = int.Parse(Console.ReadLine());

Console.WriteLine($"Enter {arrSize} elements: ");
int[] numbersArray = new int[arrSize];

for (int i = 0; i < arrSize; i++)
{
    Console.Write($"Enter the number {i + 1}: ");
    int input = int.Parse(Console.ReadLine());
    numbersArray[i] = input;
}

List<int> evenNumbersArray = new List<int>();
List<int> oddNumbersArray = new List<int>();

foreach (var number in numbersArray)
{
    if (number % 2 == 0)
    {
        evenNumbersArray.Add(number);
    }
    else
    {
        oddNumbersArray.Add(number);
    }
}

Console.WriteLine("All numbers:");
foreach (var number in numbersArray)
{
    Console.Write(number + " ");
}

Console.WriteLine("\nEven numbers:");
foreach (var number in evenNumbersArray)
{
    Console.Write(number + " ");
}

Console.WriteLine("\nOdd numbers:");
foreach (var number in oddNumbersArray)
{
    Console.Write(number + " ");
}
#endregion

#region Problem2
int arr_Size = 0;
Console.WriteLine("\nNumber of elements?");
arr_Size = int.Parse(Console.ReadLine());

Console.WriteLine($"Enter {arr_Size} elements: ");
int[] numbers_Array = new int[arr_Size];

for (int i = 0; i < arr_Size; i++)
{
    Console.Write($"Enter the number {i + 1}: ");
    int input = int.Parse(Console.ReadLine());
    numbers_Array[i] = input;
}

var elementCounts = numbers_Array.GroupBy(n => n)
    .Select(g => new { Number = g.Key, Count = g.Count(), Sum = g.Sum() });

foreach (var item in elementCounts)
{
    Console.WriteLine($"Number {item.Number}: occurs {item.Count} times, sum: {item.Sum}");
}
#endregion

#region Problem3
int inputNumber = 0;

Console.Write("Enter the number from 1 to 10: ");

inputNumber = int.Parse(Console.ReadLine());
int[] arrayOfRandomNumbers = new int[10];

Random randomNumber = new Random();
for (int i = 0; i < arrayOfRandomNumbers.Length; i++)
{
    arrayOfRandomNumbers[i] = randomNumber.Next(1, 101);
}

Console.WriteLine("Array of random 10 numbers: ");
foreach (var number in arrayOfRandomNumbers)
{
    Console.Write(number + " ");
}

Console.WriteLine($"\nTop {inputNumber} elements in this array are:");

int[] sortedNumbers = arrayOfRandomNumbers.OrderBy(n => n).ToArray();
Array.Reverse(sortedNumbers);

for (int i = 0; i < inputNumber; i++)
{
    Console.Write(sortedNumbers[i] + " ");
}
#endregion
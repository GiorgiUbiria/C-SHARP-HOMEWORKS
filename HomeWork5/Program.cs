#region Problem1
        Console.WriteLine("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double innerSquareSide = radius * Math.Sqrt(2);

        double outerSquareArea = Math.Pow(2 * radius, 2);

        double innerSquareArea = Math.Pow(innerSquareSide, 2);

        double areaDifference = outerSquareArea - innerSquareArea;

        outerSquareArea = Math.Round(outerSquareArea, 2);
        innerSquareArea = Math.Round(innerSquareArea, 2);
        areaDifference = Math.Round(areaDifference, 2);

        Console.WriteLine($"Area of the outer square: {outerSquareArea}");
        Console.WriteLine($"Area of the inner square: {innerSquareArea}");
        Console.WriteLine($"Difference in areas: {areaDifference}");
#endregion

#region Problem2
Console.Write("Enter a string: ");
string input = Console.ReadLine();

bool isWinningString = input.All(c => c == input[0]);

if (isWinningString)
{
        Console.WriteLine("The string is a jackpot.");
}
else
{
        Console.WriteLine("The string is not a jackpot.");
}
#endregion

#region Problem3
Console.Write("Enter the number of wins: ");
int wins = int.Parse(Console.ReadLine());

Console.Write("Enter the number of draws: ");
int draws = int.Parse(Console.ReadLine());

Console.Write("Enter the number of losses: ");
int losses = int.Parse(Console.ReadLine());

int totalPoints = (wins * 3) + (draws * 1) + (losses * 0);

Console.WriteLine($"The total number of points is {totalPoints}.");
#endregion

#region Problem4
Console.Write("Enter the number of hours worked each day (separated by spaces): ");
string[] inputStrings = Console.ReadLine().Split(' ');

int totalAmount = 0;

for (int i = 0; i < inputStrings.Length; i++)
{
        int hours = int.Parse(inputStrings[i]);
        int amount = 0;

        if (i < 5)
        {
                if (hours > 8)
                {
                        amount = (8 * 10) + ((hours - 8) * 15);
                }
                else
                {
                        amount = hours * 10;
                }
        }
        else
        {
                amount = hours * 20;
        }

        totalAmount += amount;
}

Console.WriteLine($"The total amount of money the person should get is ${totalAmount}.");
#endregion

#region Problem5
Console.Write("Enter a sequence of numbers (separated by spaces): ");
string[] inputString = Console.ReadLine().Split(' ');

int[] numbers = Array.ConvertAll(inputString, int.Parse);

int maxLength = 0;
int length = 1;

for (int i = 1; i < numbers.Length; i++)
{
        if (numbers[i] > numbers[i - 1])
        {
                length++;
        }
        else
        {
                maxLength = Math.Max(maxLength, length);
                length = 1;
        }
}

maxLength = Math.Max(maxLength, length);

Console.WriteLine($"The length of the longest sequence of ascending elements is {maxLength}.");
#endregion
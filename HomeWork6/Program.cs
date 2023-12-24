using System.Collections.Generic;

namespace HomeWork6 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the problem to execute:");
            Console.WriteLine("1. First Problem");
            Console.WriteLine("2. Second Problem");
            Console.WriteLine("3. Third Problem");
            Console.WriteLine("4. Fourth Problem");
            Console.WriteLine("5. Fifth Problem");
            Console.WriteLine("6. Sixth Problem");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    executeFirstProblem();
                    break;
                case "2":
                    executeSecondProblem();
                    break;
                case "3":
                    executeThirdProblem();
                    break;
                case "4":
                    executeFourthProblem();
                    break;
                case "5":
                    executeFifthProblem();
                    break;
                case "6":
                    executeSixthProblem();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 6.");
                    break;
            }
        }
        static void executeFirstProblem()
        {
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
        }
        
        
        static List<int> FindNumbers(int lowerRange, int higherRange, int power)
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

        static void executeThirdProblem()
        {
            Console.Write("Enter two strings separated by a comma: ");
            string input = Console.ReadLine();

            string[] words = input.Split(',');

            string suffix = FindCommonSuffix(words[0].Trim(), words[1].Trim());

            Console.WriteLine($"The longest common end suffix is: {suffix}");
        }
        
        
        static string FindCommonSuffix(string str1, string str2)
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

        static void executeFourthProblem()
        {
            Console.Write("Enter the elements of the list separated by comma: ");
            string inputValue = Console.ReadLine();

            if (int.TryParse(inputValue.Split(',').First(), out _))
            {
                ParseListGenerically<int>(inputValue);
            }
            else if (bool.TryParse(inputValue.Split(',').First(), out _))
            {
                ParseListGenerically<bool>(inputValue);
            }
            else
            {
                ParseListGenerically<string>(inputValue);
            }
        }
        
        static void ParseListGenerically<T>(string inputValue)
        {
            List<T> list = ParseList<T>(inputValue);

            if (typeof(T) == typeof(string))
            {
                PrintStringListInUppercase(list as dynamic);
            }
            else if (typeof(T) == typeof(int))
            {
                PrintSumOfIntList(list as dynamic);
            }
            else if (typeof(T) == typeof(bool))
            {
                PrintFirstMiddleLastOfBoolList(list as dynamic);
            }
            else
            {
                Console.WriteLine("Invalid type. Please enter string, int, or bool values.");
            }
        }
        
        static List<T> ParseList<T>(string inputValue)
        {
            return inputValue.Split(',').Select(s => (T)Convert.ChangeType(s.Trim(), typeof(T))).ToList();
        }
        
        static void PrintStringListInUppercase(List<string> list)
        {
            List<string> upperCaseList = list.Select(s => s.ToUpper()).ToList();
            Console.WriteLine(string.Join(", ", upperCaseList));
        }

        static void PrintSumOfIntList(List<int> list)
        {
            int sum = list.Sum();
            Console.WriteLine($"The sum of the list is: {sum}");
        }

        static void PrintFirstMiddleLastOfBoolList(List<bool> list)
        {
            int middleIndex = list.Count / 2;
            Console.WriteLine($"First: {list.First()}, Middle: {list[middleIndex]}, Last: {list.Last()}");
        }

        static void executeFifthProblem()
        {
            Console.Write("Enter a number: ");
            string inputVal = Console.ReadLine();

            PrintDigits(inputVal, 0);
        }
        
        
        static void PrintDigits(string number, int index)
        {
            if (index < number.Length)
            {
                Console.Write(number[index]);
                if (index < number.Length - 1)
                {
                    Console.Write("-");
                }
                PrintDigits(number, index + 1);
            }
        }

        static void executeSixthProblem()
        {
            Console.Write("Enter the elements of the array separated by comma: ");
            int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            bool hasDuplicates = HasDuplicates(array, array.Length);

            Console.WriteLine(hasDuplicates ? "The array has duplicates." : "The array does not have duplicates.");
        }
        
        
        static bool HasDuplicates(int[] arr, int n)
        {
            if (n == 1)
                return false;

            if (arr.Take(n - 1).Contains(arr[n - 1]))
                return true;

            return HasDuplicates(arr, n - 1);
        }

        static void executeSecondProblem()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            int pairCount = CountPairs(inputString);

            Console.WriteLine($"Nikusha has {pairCount} pair of socks.");
        }
        
        static int CountPairs(string input)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++; // A2, A3, C2, A4, C3
                }
                else
                {
                    charCount[c] = 1; // A1, C1, B1, B2
                }
            }

            int pairCount = 0;

            foreach (var count in charCount.Values)
            {
                pairCount += count / 2;
            }

            return pairCount;
        } 
    }
}

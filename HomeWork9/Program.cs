using System.Globalization;
using System.Xml;
using HomeWork9;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
//        CreateAndReadLast();
//        CreateMultiplicationTable();
//        SplitNodesToXML();
//          CalculateDaysBeforeBirthday();
//          CipherTheString();
    }


    static void CipherTheString()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();
        Console.Write("Enter the key: ");
        int key = Convert.ToInt32(Console.ReadLine());

        var inputData = new
        {
            word = word,
            key = key.ToString()
        };

        File.WriteAllText("cipher.json", JsonConvert.SerializeObject(inputData));

        var jsonData = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText("cipher.json"));
        string cipherWord = jsonData.word.ToString();
        int cipherKey = Convert.ToInt32(jsonData.key.ToString());

        string cipher = CaesarCipher(cipherWord, cipherKey);

        var outputData = new
        {
            Cipher = cipher
        };

        File.WriteAllText("cipher_solution.json", JsonConvert.SerializeObject(outputData));

        Console.WriteLine("The original string: " + cipherWord);
        Console.WriteLine("The ciphered string: " + cipher);
        Console.WriteLine("The cipher has been written to cipher_solution.json");
    }
    
    static string CaesarCipher(string input, int key)
    {
        string result = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result += (char)(((c + key - offset) % 26) + offset);
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
    static void CalculateDaysBeforeBirthday()
    {
        Console.Write("Enter Nikushas birthday (format: MMMM dd, yyyy): ");
        string birthday = Console.ReadLine();

        string currentDateFormatted = DateTime.Now.ToString("MMMM dd, yyyy");

        var data = new
        {
            currentDate = currentDateFormatted,
            birthday = birthday
        };

        File.WriteAllText("birthday.json", JsonConvert.SerializeObject(data));

        var json = File.ReadAllText("birthday.json");
        var info = JsonConvert.DeserializeObject<BirthdayInfo>(json);

        var currentDateParts = info.currentDate.Split(' ');
        var birthdayParts = info.birthday.Split(' ');

        var currentDay = int.Parse(currentDateParts[1].TrimEnd(','));
        var currentMonth = (Month)Enum.Parse(typeof(Month), currentDateParts[0]);

        var birthdayDay = int.Parse(birthdayParts[1].TrimEnd(','));
        var birthdayMonth = (Month)Enum.Parse(typeof(Month), birthdayParts[0]);

        var currentDate = new DateTime(DateTime.Now.Year, (int)currentMonth, currentDay);
        var nextBirthday = new DateTime(DateTime.Now.Year, (int)birthdayMonth, birthdayDay);

        if (nextBirthday < currentDate)
            nextBirthday = nextBirthday.AddYears(1);

        var remainingDays = (nextBirthday - currentDate).Days;

        Console.WriteLine($"There are {remainingDays} days left until Nikusha's birthday.");
    }
    
    static void CreateAndReadLast()
    {
        string path = "file.txt"; // bin/Debug/net7.0

        if (!File.Exists(path))
        {
            Console.Write("Enter the number of lines: ");
            int numLines = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < numLines; i++)
                {
                    Console.Write("Enter line " + (i + 1) + ": ");
                    string line = Console.ReadLine();
                    sw.WriteLine(line);
                }
            }
        }

        string lastLine = File.ReadLines(path).Last();
        Console.WriteLine("Last line in the file: " + lastLine);
    }

    static void CreateMultiplicationTable()
    {
        Console.Write("Enter a number (1 to 10): ");
        int n = Convert.ToInt32(Console.ReadLine());

        using (StreamWriter sw = File.CreateText("multiplication.txt"))
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    sw.Write(j + " * " + i + " = " + (j * i));
                    if (j != n)
                    {
                        sw.Write(" | ");
                    }
                }
                sw.WriteLine();
            }
        }

        Console.WriteLine("Multiplication table has been written to multiplication.txt");
        string[] lines = File.ReadAllLines("multiplication.txt");
        Console.WriteLine("Multiplication Table from the file:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void SplitNodesToXML()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter the number of equal parts: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int partLength = input.Length / n;
        string[] parts = new string[n];

        for (int i = 0; i < n; i++)
        {
            if (i == n - 1)
            {
                parts[i] = input.Substring(i * partLength);
            }
            else
            {
                parts[i] = input.Substring(i * partLength, partLength);
            }
        }

        using (XmlWriter writer = XmlWriter.Create("output.xml"))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("root");

            for (int i = 0; i < n; i++)
            {
                writer.WriteElementString(parts[i], "string " + (i + 1));
            }

            writer.WriteEndElement();
            writer.WriteEndDocument();
        }

        Console.WriteLine("The strings have been written to output.xml");
    }
}
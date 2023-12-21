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
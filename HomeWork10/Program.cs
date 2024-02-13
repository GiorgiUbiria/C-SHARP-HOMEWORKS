using HomeWork10;
using HomeWork10.Problem2;
using HomeWork10.Problem3;
using HomeWork10.Problem4;

void firstProblem()
{
    IFurnitureFactory factory;
    IChair chair;
    ISofa sofa;
    ICoffeeTable coffeeTable;

    factory = new VictorianFurnitureFactory();
    chair = factory.CreateChair();
    sofa = factory.CreateSofa();
    coffeeTable = factory.CreateCoffeeTable();
    Console.WriteLine(chair.HasLegs());
    Console.WriteLine(chair.SitOn());
    Console.WriteLine(sofa.HasLegs());
    Console.WriteLine(sofa.SitOn());
    Console.WriteLine(coffeeTable.HasLegs());
    Console.WriteLine(coffeeTable.SitOn());

    factory = new ModernFurnitureFactory();
    chair = factory.CreateChair();
    sofa = factory.CreateSofa();
    coffeeTable = factory.CreateCoffeeTable();
    Console.WriteLine(chair.HasLegs());
    Console.WriteLine(chair.SitOn());
    Console.WriteLine(sofa.HasLegs());
    Console.WriteLine(sofa.SitOn());
    Console.WriteLine(coffeeTable.HasLegs());
    Console.WriteLine(coffeeTable.SitOn());

    factory = new ArtDecoFurnitureFactory();
    chair = factory.CreateChair();
    sofa = factory.CreateSofa();
    coffeeTable = factory.CreateCoffeeTable();
    Console.WriteLine(chair.HasLegs());
    Console.WriteLine(chair.SitOn());
    Console.WriteLine(sofa.HasLegs());
    Console.WriteLine(sofa.SitOn());
    Console.WriteLine(coffeeTable.HasLegs());
    Console.WriteLine(coffeeTable.SitOn());
}

void secondProblem()
{
    MainActor mainActor = new MainActor();

    CascadingActor cascadingActor = new CascadingActor(mainActor);

    mainActor.PlayRole();
    cascadingActor.PlayRole();    
}

void thirdProblem()
{
    ReportFacade reportFacade = new ReportFacade();

    string header = "My Header";
    string body = "Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add.";
    string footer = "My Footer";

    reportFacade.CreateHtmlReport(header, body, footer);

    header = "I’m using Facade Pattern";
    body = "Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document. To make your document look professionally produced, Word provides";
    footer = "Page 1";

    reportFacade.CreatePdfReport(header, body, footer);   
}

void fourthProblem()
{
    FileContext context = new FileContext();

//   string filePath = "text.txt";
//    string filePath = "json.json";
    string filePath = "files.zip";

    switch (Path.GetExtension(filePath))
    {
        case ".zip":
            context.SetStrategy(new ZipFileStrategy());
            break;
        case ".json":
            context.SetStrategy(new JsonFileStrategy());
            break;
        case ".txt":
            context.SetStrategy(new TxtFileStrategy());
            break;
        default:
            Console.WriteLine("Unsupported file type.");
            return;
    }

    context.ExecuteStrategy(filePath);
}

fourthProblem();
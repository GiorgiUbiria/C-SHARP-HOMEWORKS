namespace HomeWork10;

public class VictorianFurnitureFactory : IFurnitureFactory 
{
    public IChair CreateChair() => new VictorianChair();

    public ISofa CreateSofa() => new VictorianSofa();

    public ICoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();
}

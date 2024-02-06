namespace HomeWork10;

public class ModernFurnitureFactory : IFurnitureFactory 
{
    public IChair CreateChair() => new ModernChair();

    public ISofa CreateSofa() => new ModernSofa();

    public ICoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();
}

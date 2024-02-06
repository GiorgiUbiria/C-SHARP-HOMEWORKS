namespace HomeWork10;

public class ArtDecoFurnitureFactory : IFurnitureFactory 
{
    public IChair CreateChair() => new ArtDecoChair();

    public ISofa CreateSofa() => new ArtDecoSofa();

    public ICoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();
}

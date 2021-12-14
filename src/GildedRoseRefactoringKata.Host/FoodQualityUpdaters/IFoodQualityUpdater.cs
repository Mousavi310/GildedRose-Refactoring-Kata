namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public interface IFoodQualityUpdater
{
    public string Name { get;}
    void Verify(Item item);
}
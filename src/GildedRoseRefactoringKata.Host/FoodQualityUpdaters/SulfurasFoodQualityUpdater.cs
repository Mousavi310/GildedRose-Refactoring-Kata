namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public class SulfurasFoodQualityUpdater : IFoodQualityUpdater
{
    public string Name => "Sulfuras, Hand of Ragnaros";
    public void Verify(Item item)
    {
        // Do nothing about Sulfuras Quality
        
    }
}
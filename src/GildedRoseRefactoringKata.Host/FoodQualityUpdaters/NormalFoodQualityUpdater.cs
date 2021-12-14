namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public class NormalFoodQualityUpdater : IFoodQualityUpdater
{
    public string Name => null;
    public void Verify(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 1;
        }
        
        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }
    }
}
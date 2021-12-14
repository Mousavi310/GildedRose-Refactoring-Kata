namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public class ConjuredFoodQualityUpdater : IFoodQualityUpdater
{
    public string Name => "Conjured Mana Cake";
    public void Verify(Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 2;
        }
        
        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 2;
            }
        }

        if (item.Quality < 0)
        {
            item.Quality = 0;
        }
    }
}
namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public class BackstagePassesFoodQualityUpdater : IFoodQualityUpdater
{
    public string Name => "Backstage passes to a TAFKAL80ETC concert";

    public void Verify(Item item)
    {
        if (item.Quality < 50)
        {
            if (item.Quality < 6)
            {
                item.Quality += 3;
            }
            else if(item.Quality < 11)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }
        }
        
        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }
}
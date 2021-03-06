using GildedRoseRefactoringKata.Host.Options;
using Microsoft.Extensions.Options;

namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public class AgedBrieFoodQualityUpdater : IFoodQualityUpdater
{
    private readonly IOptions<FoodOptions> _options;

    public AgedBrieFoodQualityUpdater(IOptions<FoodOptions> options)
    {
        _options = options;
    }
    public string Name => "Aged Brie";
    public void Verify(Item item)
    {
        if (item.Quality < 50)
        {
            item.Quality += 1;
        }

        item.SellIn -= 1;

        if (item.SellIn < 0)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }
    }
}
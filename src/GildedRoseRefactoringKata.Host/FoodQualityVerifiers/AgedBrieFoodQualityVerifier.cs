using GildedRoseRefactoringKata.Host.Options;
using Microsoft.Extensions.Options;

namespace GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

public class AgedBrieFoodQualityVerifier : IFoodQualityVerifier
{
    private readonly IOptions<FoodOptions> _options;

    public AgedBrieFoodQualityVerifier(IOptions<FoodOptions> options)
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
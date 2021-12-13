namespace GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

public class BackstagePassesFoodQualityVerifier : IFoodQualityVerifier
{
    public string Name => "Backstage passes to a TAFKAL80ETC concert";

    public void Verify(Item item)
    {
        throw new NotImplementedException();
    }
}
namespace GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

public class SulfurasFoodQualityVerifier : IFoodQualityVerifier
{
    public string Name => "Sulfuras, Hand of Ragnaros";
    public void Verify(Item item)
    {
        throw new NotImplementedException();
    }
}
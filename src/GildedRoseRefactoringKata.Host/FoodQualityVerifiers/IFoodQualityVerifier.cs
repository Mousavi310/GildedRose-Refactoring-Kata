namespace GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

public interface IFoodQualityVerifier
{
    public string Name { get;}
    void Verify(Item item);
}
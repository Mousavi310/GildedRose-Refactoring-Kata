namespace GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

public interface IFoodQualityVerifierFactory
{
    IFoodQualityVerifier Create(string name);
}
namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public interface IFoodQualityUpdaterFactory
{
    IFoodQualityUpdater Create(string name);
}
namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

public class FoodQualityUpdaterFactory : IFoodQualityUpdaterFactory
{
    private readonly IEnumerable<IFoodQualityUpdater> _verifiers;

    public FoodQualityUpdaterFactory(IEnumerable<IFoodQualityUpdater> verifiers)
    {
        _verifiers = verifiers;
    }
    
    public IFoodQualityUpdater Create(string name)
    {
        var verifier =  _verifiers.FirstOrDefault(v => v.Name == name);

        if (verifier == null)
        {
            verifier = _verifiers.FirstOrDefault(v => v is NormalFoodQualityUpdater);
        }

        return verifier;
    }
}
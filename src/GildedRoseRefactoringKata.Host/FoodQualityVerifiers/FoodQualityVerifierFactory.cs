namespace GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

public class FoodQualityVerifierFactory : IFoodQualityVerifierFactory
{
    private readonly IEnumerable<IFoodQualityVerifier> _verifiers;

    public FoodQualityVerifierFactory(IEnumerable<IFoodQualityVerifier> verifiers)
    {
        _verifiers = verifiers;
    }
    
    public IFoodQualityVerifier Create(string name)
    {
        var verifier =  _verifiers.FirstOrDefault(v => v.Name == name);

        if (verifier == null)
        {
            verifier = _verifiers.FirstOrDefault(v => v is NormalFoodQualityVerifier);
        }

        return verifier;
    }
}
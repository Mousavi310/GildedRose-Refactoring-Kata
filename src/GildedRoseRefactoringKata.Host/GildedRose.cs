using GildedRoseRefactoringKata.Host.FoodQualityVerifiers;

namespace GildedRoseRefactoringKata.Host
{
    public class GildedRose
    {
        private readonly IFoodQualityVerifierFactory _factory;
        IList<Item> Items;
        public GildedRose(IFoodQualityVerifierFactory factory)
        {
            _factory = factory;
        }

        public void SetItems(IList<Item> items)
        {
            this.Items = items;
        }

        public void UpdateQuality()
        {
            if (Items == null)
            {
                throw new InvalidOperationException($"{nameof(Items)} is null.");
            }

            foreach (var item in Items)
            {
                var verifier = _factory.Create(item.Name);
                verifier.Verify(item);
            }
        }
    }
}

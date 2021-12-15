using GildedRoseRefactoringKata.Host.FoodQualityUpdaters;

namespace GildedRoseRefactoringKata.Host
{
    public class GildedRose
    {
        private readonly IFoodQualityUpdaterFactory _factory;
        IList<Item> Items;
        public GildedRose(IFoodQualityUpdaterFactory factory)
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
                var qualityUpdater = _factory.Create(item.Name);
                qualityUpdater.Verify(item);
            }
        }
    }
}

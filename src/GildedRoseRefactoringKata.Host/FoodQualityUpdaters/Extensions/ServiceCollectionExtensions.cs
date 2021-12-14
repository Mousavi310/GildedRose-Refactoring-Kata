using Microsoft.Extensions.DependencyInjection;

namespace GildedRoseRefactoringKata.Host.FoodQualityUpdaters.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddFoodQualityUpdaters(this IServiceCollection services)
    {
        services.AddSingleton<IFoodQualityUpdater, AgedBrieFoodQualityUpdater>();
        services.AddSingleton<IFoodQualityUpdater, BackstagePassesFoodQualityUpdater>();
        services.AddSingleton<IFoodQualityUpdater, NormalFoodQualityUpdater>();
        services.AddSingleton<IFoodQualityUpdater, SulfurasFoodQualityUpdater>();
        services.AddSingleton<IFoodQualityUpdater, ConjuredFoodQualityUpdater>();

        return services;
    }
}
using GildedRoseRefactoringKata.Host;
using GildedRoseRefactoringKata.Host.FoodQualityUpdaters;
using GildedRoseRefactoringKata.Host.FoodQualityUpdaters.Extensions;
using GildedRoseRefactoringKata.Host.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx, services) =>
    {
        services.TryAddSingleton<GildedRose>();
        services.TryAddSingleton<Inventory>();
        services.TryAddSingleton<IFoodQualityUpdaterFactory, FoodQualityUpdaterFactory>();
        services.AddOptions<FoodOptions>().Bind(ctx.Configuration.GetSection(FoodOptions.SectionName))
            .ValidateDataAnnotations();
        services.AddFoodQualityUpdaters();
    })
    .ConfigureAppConfiguration(builder =>
    {
        builder.AddJsonFile("appsettings.json", false);
    })
    .Build();

var inventory = host.Services.GetRequiredService<Inventory>();
inventory.Run();

await host.RunAsync();


    
    
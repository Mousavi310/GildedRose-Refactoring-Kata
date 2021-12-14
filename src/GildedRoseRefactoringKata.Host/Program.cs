// See https://aka.ms/new-console-template for more information

using GildedRoseRefactoringKata.Host;
using GildedRoseRefactoringKata.Host.FoodQualityVerifiers;
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
        services.TryAddSingleton<IFoodQualityVerifierFactory, FoodQualityVerifierFactory>();
        services.AddOptions<FoodOptions>().Bind(ctx.Configuration.GetSection(FoodOptions.SectionName))
            .ValidateDataAnnotations();
    })
    .ConfigureAppConfiguration(builder =>
    {
        builder.AddJsonFile("appsettings.json", false);
    })
    .Build();

var gildedRose = host.Services.GetRequiredService<Inventory>();
gildedRose.Run();

await host.RunAsync();


    
    
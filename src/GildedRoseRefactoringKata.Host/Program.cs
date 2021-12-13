// See https://aka.ms/new-console-template for more information

using GildedRoseRefactoringKata.Host;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.TryAddSingleton<GildedRose>();
    })
    .Build();

var gildedRose = host.Services.GetRequiredService<GildedRose>();
gildedRose.UpdateQuality();

await host.RunAsync();


    
    
using System;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using GildedRoseRefactoringKata.Host.FoodQualityUpdaters;
using GildedRoseRefactoringKata.Host.Options;
using Xunit;

namespace GildedRoseRefactoringKata.Host.Tests;

[UseReporter(typeof(DiffReporter))]
public class ApprovalTest
{
    [Fact]
    public void ThirtyDays()
    {
        StringBuilder fakeoutput = new StringBuilder();
        
        Console.SetOut(new StringWriter(fakeoutput));
        Console.SetIn(new StringReader("a\n"));

        var inventory = new Inventory(new GildedRose(new FoodQualityUpdaterFactory(
            new IFoodQualityUpdater[]
            {
                new ConjuredFoodQualityUpdater(),
                new NormalFoodQualityUpdater(),
                new SulfurasFoodQualityUpdater(),
                new AgedBrieFoodQualityUpdater(
                    Microsoft.Extensions.Options.Options.Create(new FoodOptions {QualityThreshold = 50})),
                new BackstagePassesFoodQualityUpdater()
            })));
        
        inventory.Run();

        var output = fakeoutput.ToString();
        
        Approvals.Verify(output);
    }

}
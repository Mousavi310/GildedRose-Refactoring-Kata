using System.ComponentModel.DataAnnotations;

namespace GildedRoseRefactoringKata.Host.Options;

public class FoodOptions
{
    public const string SectionName = "Food";

    [Range(1, 1000)] 
    public int QualityThreshold { get; set; } = 50;
}
namespace GildedRoseRefactoringKata.Host;

public class Inventory
{
    private readonly GildedRose _gildedRose;

    public Inventory(GildedRose gildedRose)
    {
        _gildedRose = gildedRose;
    }

    public void Run()
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>{
            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            },
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        };

        _gildedRose.SetItems(items);


        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j]);
            }
            Console.WriteLine("");
            _gildedRose.UpdateQuality();
        }
    }
}
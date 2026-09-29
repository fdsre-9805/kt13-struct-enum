using System;

class Program
{
    static void Main()
    {
        Item[] items =
        {
            new Item { Name = "Daedalus",  Rarity = ItemRarity.Legendary, Slot = ItemSlot.Weapon },
            new Item { Name = "Cerassa",   Rarity = ItemRarity.Common,    Slot = ItemSlot.Armor },
            new Item { Name = "Ring",      Rarity = ItemRarity.Epic,      Slot = ItemSlot.Accessory },
            new Item { Name = "Aeon Disk", Rarity = ItemRarity.Rare,      Slot = ItemSlot.Armor },
            new Item { Name = "Hydra",     Rarity = ItemRarity.Rare,      Slot = ItemSlot.Weapon }
        };

        foreach (Item item in items)
            Console.WriteLine(item);

        Item local = items[0];
        local.Rarity = ItemRarity.Common;

        Console.WriteLine(items[0]);
        Console.WriteLine(local);

        if (Enum.TryParse("Epic", out ItemRarity rog1))
            Console.WriteLine($"Epic → {rog1}");

        if (!Enum.TryParse("Mythic", out ItemRarity rog2))
            Console.WriteLine("Mythic нет в игре");
    }
}

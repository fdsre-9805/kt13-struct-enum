using System;

class Program
{
    static void Main()
    {
        List<Item> items = new List<Item>
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
            Console.WriteLine($"Epic = {rog1}");

        if (!Enum.TryParse("Mythic", out ItemRarity rog2))
            Console.WriteLine("Mythic нет в игре");

        Console.WriteLine();
        while (true)
        {
            Console.Write("Название предмета (Enter — закончить): ");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
                break;

            ItemRarity rarity;
            while (true)
            {
                Console.Write("Редкость (Common, Rare, Epic, Legendary): ");
                string? input = Console.ReadLine();
                if (input == null)
                    return;
                if (Enum.TryParse(input, true, out rarity) && Enum.IsDefined(rarity))
                    break;
                Console.WriteLine($"Редкости \"{input}\" нет в игре");
            }

            ItemSlot slot;
            while (true)
            {
                Console.Write("Слот (Weapon, Armor, Accessory): ");
                string? input = Console.ReadLine();
                if (input == null)
                    return;
                if (Enum.TryParse(input, true, out slot) && Enum.IsDefined(slot))
                    break;
                Console.WriteLine($"Слота \"{input}\" нет в игре");
            }

            Item newItem = new Item(name, rarity, slot);
            items.Add(newItem);
            Console.WriteLine($"Создан: {newItem}");
            Console.WriteLine();
        }

        Console.WriteLine("Все предметы:");
        foreach (Item item in items)
            Console.WriteLine(item);
    }
}

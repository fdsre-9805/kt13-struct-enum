enum ItemRarity { Common, Rare, Epic, Legendary }
enum ItemSlot { Weapon, Armor, Accessory }

struct Item
{
    public string Name;
    public ItemRarity Rarity;
    public ItemSlot Slot;

    public Item(string name, ItemRarity rarity, ItemSlot slot)
    {
        Name = name;
        Rarity = rarity;
        Slot = slot;
    }

    public override string ToString() => $"{Name} ({Rarity}, {Slot})";
}

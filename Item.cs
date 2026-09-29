enum ItemRarity { Common, Rare, Epic, Legendary }
enum ItemSlot { Weapon, Armor, Accessory }

struct Item
{
    public string Name;
    public ItemRarity Rarity;
    public ItemSlot Slot;

    public override string ToString() => $"{Name} ({Rarity}, {Slot})";
}

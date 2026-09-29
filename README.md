# КТ №13 — Коллекция структур и перечисления

**Вариант 2 — RPG-предмет**

## Проверочные ключи

| Действие | Ожидаемый результат |
|---|---|
| `items[0]` (до изменения копии) | `Daedalus (Legendary, Weapon)` |
| копия `items[0]`, `Rarity` копии изменена на `Common` | копия — `Daedalus (Common, Weapon)`, `items[0]` — без изменений |
| `Enum.TryParse<ItemRarity>("Epic", out var r)` | `true`, `r == ItemRarity.Epic` |
| `Enum.TryParse<ItemRarity>("Mythic", out var r)` | `false`, без исключения |

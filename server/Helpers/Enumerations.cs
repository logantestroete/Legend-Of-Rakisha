
namespace server.Helpers.Enumerations
{
    public enum ItemType
    {
        Armor,
        Weapon,
        Jewlery
    }
    public enum ItemWeight
    {
        Light,
        Medium,
        Heavy
    }
    public enum ItemSubType
    {
        // Weapons
        OneHandedSword,
        TwoHandedSword,
        Bow,
        Staff,
        Dagger,
        OneHandedAxe,
        TwoHandedAxe,
        OneHandedMace,
        TwoHandedMace,

        // Armor
        Hat,
        Chest,
        Gloves,
        Boots,
        Shield,

        // Jewlery
        Ring,
        Amulet
    }

    public enum Stat
    {
        Health,
        Attack,
        SpellDamage,
        Defense,
        MagicResist,
        CritChance,
        CritDamage
    }

    public enum ModifierType
    {
        Add,
        AddPercentage
    }

    public enum AffixType
    {
        StatModifier,
        GameplayModifier
    }

    public enum AffixCategory
    {
        Prefix,
        Suffix
    }

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Divine,
        Unique
    }
}
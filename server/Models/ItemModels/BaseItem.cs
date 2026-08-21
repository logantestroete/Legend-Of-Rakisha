using server.Helpers.Enumerations;

namespace server.Models.ItemModels
{
    public class BaseItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ItemType ItemType { get; set; }
        public ItemSubType ItemSubType { get; set; }
        public ItemWeight Weight { get; set; }
        public int NumSlots { get; set; }
        public bool IsUnique { get; set; }
        public ICollection<BaseItemModifier> BaseModifiers = new List<BaseItemModifier>();
        public ICollection<BaseItemAffixPool> Affixes = new List<BaseItemAffixPool>();
    }
}
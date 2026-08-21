using server.Helpers.Enumerations;

namespace server.Models.ItemModels
{
    public class ItemInstance
    {
        public Guid Id { get; set; }
        public Guid BaseItemId { get; set; }
        public BaseItem BaseItem { get; set; }
        public string Name { get; set; }
        public Rarity Rarity { get; set; }
        public int Level { get; set; }
        public ICollection<ItemInstanceAffix> Affixes = new List<ItemInstanceAffix>();
    }
}
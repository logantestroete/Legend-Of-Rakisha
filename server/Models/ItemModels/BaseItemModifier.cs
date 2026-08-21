using server.Helpers.Enumerations;

namespace server.Models.ItemModels
{
    public class BaseItemModifier
    {
        public Guid Id { get; set; }
        public Guid BaseItemId { get; set; }
        public BaseItem BaseItem { get; set; }
        public Stat Stat { get; set; }
        public ModifierType ModifierType { get; set; }
        public int value { get; set; }
    }
}
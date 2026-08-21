
namespace server.Models.ItemModels
{
    public class BaseItemAffixPool
    {
        public Guid Id { get; set; }
        public Guid BaseItemId { get; set; }
        public BaseItem BaseItem { get; set; }
        public Guid AffixId { get; set; }
        public Affix Affix { get; set; }
    }
}
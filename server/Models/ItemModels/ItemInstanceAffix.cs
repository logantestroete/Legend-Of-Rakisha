
namespace server.Models.ItemModels
{
    public class ItemInstanceAffix
    {
        public Guid Id { get; set; }
        public Guid ItemInstanceId { get; set; }
        public ItemInstance ItemInstance { get; set; }
        public Guid AffixId { get; set; }
        public Affix Affix { get; set; }
        public int RolledValue { get; set; }
    }
}
using server.Helpers.Enumerations;

namespace server.Models.ItemModels
{
    public class Affix
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public AffixCategory AffixCategory { get; set; }
        public AffixType AffixType { get; set; }
        public ModifierType ModifierType { get; set; }
        public string Description { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public Stat Stat { get; set; }
    }
}
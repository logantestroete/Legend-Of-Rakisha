using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using server.Models.ItemModels;
namespace LoR.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(
        DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    // Tables
    DbSet<BaseItem> BaseItems => Set<BaseItem>();
    DbSet<BaseItemModifier> BaseItemModifiers => Set<BaseItemModifier>();
    DbSet<BaseItemAffixPool> BaseItemAffixPool => Set<BaseItemAffixPool>();
    DbSet<Affix> Affixs => Set<Affix>();
    DbSet<ItemInstance> ItemInstances => Set<ItemInstance>();
    DbSet<ItemInstanceAffix> ItemInstanceAffixes => Set<ItemInstanceAffix>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<BaseItem>()
            .Property(x => x.ItemType)
            .HasConversion<string>();

        modelBuilder.Entity<BaseItem>()
            .Property(x => x.ItemSubType)
            .HasConversion<string>();

        modelBuilder.Entity<BaseItemModifier>()
            .Property(x => x.ModifierType)
            .HasConversion<string>();

        modelBuilder.Entity<BaseItemModifier>()
            .Property(x => x.Stat)
            .HasConversion<string>();

        modelBuilder.Entity<Affix>()
            .Property(x => x.AffixCategory)
            .HasConversion<string>();
        modelBuilder.Entity<Affix>()
            .Property(x => x.AffixType)
            .HasConversion<string>();
        modelBuilder.Entity<Affix>()
            .Property(x => x.ModifierType)
            .HasConversion<string>();
        modelBuilder.Entity<Affix>()
            .Property(x => x.Stat)
            .HasConversion<string>();
        modelBuilder.Entity<ItemInstance>()
            .Property(x => x.Rarity)
            .HasConversion<string>();
    }
}
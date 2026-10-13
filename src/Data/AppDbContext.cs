using Microsoft.EntityFrameworkCore;
using paystream.src.models;

namespace paystream.src.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<TransactionModel> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TransactionModel>(entity =>
        {
            entity.HasKey(t => t.TransactionId);
            entity.Property(t => t.MerchantId).IsRequired();
            entity.Property(t => t.AccountId).IsRequired();
            entity.Property(t => t.Currency).IsRequired();
            entity.Property(t => t.Amount).IsRequired();
            entity.Property(t => t.Status).IsRequired();
            entity.Property(t => t.BillingCountry).IsRequired();
            entity.Property(t => t.OccurredAt).IsRequired();
            entity.Property(t => t.CreatedAt).IsRequired();
            entity.Property(t => t.UpdatedAt).IsRequired();
        });
    }
}
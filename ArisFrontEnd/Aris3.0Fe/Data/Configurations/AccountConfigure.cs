using Aris3._0Fe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aris3._0Fe.Data.Configurations
{
    public class AccountConfigure : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(a => a.Id);

            builder.ToTable("Accounts");

            // Account ↔ Otp (1:N)
            builder.HasMany(a => a.Otps)
                   .WithOne(o => o.Account)
                   .HasForeignKey(o => o.AccounId);

            // Account ↔ WatchList (1:N)
            builder.HasMany(a => a.WatchLists)
                   .WithOne(w => w.Account)
                   .HasForeignKey(w => w.AccountId);

            // Account ↔ Subscription (N:1)
            builder.HasOne(a => a.Subscription)
       .WithMany(s => s.Accounts) // many accounts can share the same subscription
       .HasForeignKey(a => a.SubscriptionId)
       .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

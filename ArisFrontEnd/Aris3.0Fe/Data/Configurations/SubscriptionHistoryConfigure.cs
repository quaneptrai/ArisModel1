using Aris3._0Fe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aris3._0Fe.Data.Configurations
{
    public class SubscriptionHistoryConfigure : IEntityTypeConfiguration<SubscriptionHistory>
    {
        public void Configure(EntityTypeBuilder<SubscriptionHistory> builder)
        {
            builder.HasKey(sh => sh.Id);

            // SubscriptionHistory -> Account
            builder.HasOne(sh => sh.Account)
       .WithMany(a => a.SubscriptionHistories)
       .HasForeignKey(sh => sh.AccountId)
       .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(sh => sh.Subscription)
                   .WithMany(s => s.SubscriptionHistories)
                   .HasForeignKey(sh => sh.SubscriptionId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

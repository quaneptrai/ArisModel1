using Aris3._0Fe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aris3._0Fe.Data.Configurations
{
    public class NotifyMessageConfigure : IEntityTypeConfiguration<NotifyMessage>
    {
        public void Configure(EntityTypeBuilder<NotifyMessage> builder)
        {
            builder.HasKey(nm => nm.Id);

            builder.Property(nm => nm.Title)
                  .IsRequired()
                  .HasMaxLength(200);

            builder.Property(nm => nm.Content)
                  .IsRequired();

            builder.Property(nm => nm.CreatedAt)
                  .IsRequired();

            builder.Property(nm => nm.IsRead)
                  .IsRequired();

            builder.HasOne(nm => nm.Account)
                  .WithMany()
                  .HasForeignKey(nm => nm.AccountId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
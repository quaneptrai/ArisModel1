using Aris3._0.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aris3._0.Infrastructure.Data.Configurations
{
    public class WatchListConfigure : IEntityTypeConfiguration<WatchList>
    {
        public void Configure(EntityTypeBuilder<WatchList> builder)
        {
            builder.HasKey(w => w.Id);

            // WatchList → Film (many-to-one)
            builder.HasOne(w => w.Film)
                   .WithMany(f => f.WatchLists)
                   .HasForeignKey(w => w.FilmId)
                   .OnDelete(DeleteBehavior.Restrict);

            // WatchList → Account (many-to-one)
            builder.HasOne(w => w.Account)
                   .WithMany(a => a.WatchLists)
                   .HasForeignKey(w => w.AccountId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
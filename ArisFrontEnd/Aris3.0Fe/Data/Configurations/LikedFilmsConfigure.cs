using Aris3._0Fe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aris3._0Fe.Data.Configurations
{
    public class LikedFilmsConfigure : IEntityTypeConfiguration<LikedFilms>
    {
        public void Configure(EntityTypeBuilder<LikedFilms> builder)
        {
            builder.HasKey(lf => lf.Id);

            builder.Property(lf => lf.AddedAt)
                  .IsRequired();

            builder.HasOne(lf => lf.Account)
                  .WithMany()
                  .HasForeignKey(lf => lf.AccountId)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(lf => lf.Film)
                  .WithMany()
                  .HasForeignKey(lf => lf.FilmId)
                  .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
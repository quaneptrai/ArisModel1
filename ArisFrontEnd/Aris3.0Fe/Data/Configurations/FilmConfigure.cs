using Aris3._0Fe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aris3._0Fe.Data.Configurations
{
    public class FilmConfigure : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasKey(f => f.Id);

            // Film ↔ WatchList (1:N)
            builder.HasMany(f => f.WatchLists)
                   .WithOne(w => w.Film)
                   .HasForeignKey(w => w.FilmId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Film ↔ Category (M:N)
            builder.HasMany(f => f.Categories)
                   .WithMany(c => c.Films)
                   .UsingEntity(j => j.ToTable("CategoryFilm"));

            // Film ↔ Actor (M:N)
            builder.HasMany(f => f.Actors)
                   .WithMany(a => a.Films)
                   .UsingEntity(j => j.ToTable("ActorFilm"));

            // Film ↔ Director (M:N)
            builder.HasMany(f => f.Directors)
                   .WithMany(d => d.Films)
                   .UsingEntity(j => j.ToTable("DirectorFilm"));

            // Film ↔ Country (M:N)
            builder.HasMany(f => f.Countries)
                   .WithMany(c => c.Films)
                   .UsingEntity(j => j.ToTable("CountryFilm"));

            // Film ↔ Server (1:N)
            builder.HasMany(f => f.Servers)
                   .WithOne(s => s.Film)
                   .HasForeignKey(s => s.FilmId);
        }
    }
}

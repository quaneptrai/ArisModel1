using Aris3._0Fe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aris3._0FE.Data.Context
{
    public class ArisDbContext : DbContext
    {
        public ArisDbContext(DbContextOptions<ArisDbContext> options) : base(options)
        {

        }
        public DbSet<Tmbd> Tmbd { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Created> Created { get; set; }
        public DbSet<Modified> Modified { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Otp> Otps { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
        public DbSet<LikedFilms> LikedFilms { get; set; }
        public DbSet<NotifyMessage> NotifyMessages { get; set; }
        public DbSet<SupportedDevice> SupportedDevices { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<SubscriptionHistory> subscriptionHistories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArisDbContext).Assembly);

            var personAdminId = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");
            var personUser1Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");
            var personUser2Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");
            var now = DateTime.UtcNow;
            // Seed SupportedDevices
            modelBuilder.Entity<SupportedDevice>().HasData(
     new SupportedDevice { Id = 1, DeviceName = "Mobile phone" },
     new SupportedDevice { Id = 2, DeviceName = "Tablet" },
     new SupportedDevice { Id = 3, DeviceName = "TV" },
     new SupportedDevice { Id = 4, DeviceName = "Computer" }
 );

            // Seed Subscriptions
            modelBuilder.Entity<Subscription>().HasData(
                new Subscription
                {
                    Id = 1,
                    Name = "Mobile",
                    MonthlyPrice = 74000,
                    Quality = "Fair",
                    Resolution = "480p",
                    MaxScreen = 1,
                    MaxDownload = 1,
                    CreatedDate = now,
                    UpdatedDate = now,
                    Type = "Mobile"
                },
                new Subscription
                {
                    Id = 2,
                    Name = "Basic",
                    MonthlyPrice = 114000,
                    Quality = "Good",
                    Resolution = "720p",
                    MaxScreen = 1,
                    MaxDownload = 1,
                    CreatedDate = now,
                    UpdatedDate = now,
                    Type = "Basic"
                },
                new Subscription
                {
                    Id = 3,
                    Name = "Standard",
                    MonthlyPrice = 231000,
                    Quality = "Great",
                    Resolution = "1080 (Full HD)",
                    MaxScreen = 2,
                    MaxDownload = 2,
                    CreatedDate = now,
                    UpdatedDate = now,
                    Type = "Standard"
                },
                new Subscription
                {
                    Id = 4,
                    Name = "Prenium",
                    MonthlyPrice = 273000,
                    Quality = "Best",
                    Resolution = "4k (Ultra HD) + HDR",
                    MaxScreen = 4,
                    MaxDownload = 6,
                    CreatedDate = now,
                    UpdatedDate = now,
                    Type = "Prenium"
                }
            );

            // Seed Persons
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    id = personAdminId,
                    Name = "Admin Person",
                    Email = "admin@gmail.com",
                    Role = "Admin",
                    PhoneNumber = "0123456789",
                    City = "Hanoi",
                    State = "HN",
                    Zipcode = "100000",
                    Country = "Vn",
                    Region = "Sea",
                    AccountStat = true,
                    Created = now,
                    LastUpdated = now,
                },
                new Person
                {
                    id = personUser1Id,
                    Name = "User One",
                    Email = "user1@gmail.com",
                    Role = "User",
                    PhoneNumber = "0987654321",
                    City = "HCMC",
                    State = "HCM",
                    Zipcode = "700000",
                    Country = "Vn",
                    Region = "Sea",
                    AccountStat = true,
                    Created = now,
                    LastUpdated = now
                },
                new Person
                {
                    id = personUser2Id,
                    Name = "User Two",
                    Email = "user2@gmail.com",
                    Role = "User",
                    PhoneNumber = "0911222333",
                    City = "Danang",
                    State = "DN",
                    Zipcode = "550000",
                    Country = "Vn",
                    Region = "Sea",
                    AccountStat = true,
                    Created = now,
                    LastUpdated = now
                }
            );

            // Seed Accounts
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = new Guid("11111111-1111-1111-1111-111111111111"),
                    UserName = "admin",
                    Email = "admin@gmail.com",
                    Password = "admin123",
                    Role = "Admin",
                    Status = true,
                    AccountStat = true,
                    Created = now,
                    LastUpdated = now,
                    PersonId = personAdminId,
                    SubscriptionId = 1
                },
                new Account
                {
                    Id = new Guid("22222222-2222-2222-2222-222222222222"),
                    UserName = "user1",
                    Email = "user1@gmail.com",
                    Password = "user123",
                    Role = "User",
                    Status = true,
                    AccountStat = true,
                    Created = now,
                    LastUpdated = now,
                    PersonId = personUser1Id,
                    SubscriptionId = 2
                },
                new Account
                {
                    Id = new Guid("33333333-3333-3333-3333-333333333333"),
                    UserName = "user2",
                    Email = "user2@gmail.com",
                    Password = "user123",
                    Role = "User",
                    Status = true,
                    AccountStat = true,
                    Created = now,
                    LastUpdated = now,
                    PersonId = personUser2Id,
                    SubscriptionId = 3
                }
            );
            modelBuilder.Entity<SubscriptionHistory>().HasData(
            new SubscriptionHistory
            {
                Id = 1,
                AccountId = new Guid("11111111-1111-1111-1111-111111111111"),
                SubscriptionId = 1,
                SubscriptionMethod = "Momo",
                StartDate = now,
                EndDate = now.AddMonths(1)
            },
            new SubscriptionHistory
            {
                Id = 2,
                AccountId = new Guid("22222222-2222-2222-2222-222222222222"),
                SubscriptionId = 2,
                SubscriptionMethod = "Visa",
                StartDate = now,
                EndDate = now.AddMonths(1)
            },
            new SubscriptionHistory
            {
                Id = 3,
                AccountId = new Guid("33333333-3333-3333-3333-333333333333"),
                SubscriptionId = 3,
                SubscriptionMethod = "Card",
                StartDate = now,
                EndDate = now.AddMonths(1)
            }
            );
           // Configure LikedFilms relationships
           modelBuilder.Entity<LikedFilms>()
                .HasOne(lf => lf.Account)
                .WithMany()
                .HasForeignKey(lf => lf.AccountId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LikedFilms>()
                .HasOne(lf => lf.Film)
                .WithMany()
                .HasForeignKey(lf => lf.FilmId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure NotifyMessage relationships
            modelBuilder.Entity<NotifyMessage>()
                .HasOne(nm => nm.Account)
                .WithMany()
                .HasForeignKey(nm => nm.AccountId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
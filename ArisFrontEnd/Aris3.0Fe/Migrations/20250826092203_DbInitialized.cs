using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Aris3._0Fe.Migrations
{
    /// <inheritdoc />
    public partial class DbInitialized : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Created",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Created", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modified",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modified", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountStat = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MonthlyPrice = table.Column<int>(type: "int", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxScreen = table.Column<int>(type: "int", nullable: false),
                    MaxDownload = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupportedDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportedDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tmbd",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Season = table.Column<int>(type: "int", nullable: true),
                    Vote_average = table.Column<float>(type: "real", nullable: false),
                    Vote_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tmbd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AccountStat = table.Column<bool>(type: "bit", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accounts_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionSupportedDevices",
                columns: table => new
                {
                    SubscriptionsId = table.Column<int>(type: "int", nullable: false),
                    SupportedDevicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionSupportedDevices", x => new { x.SubscriptionsId, x.SupportedDevicesId });
                    table.ForeignKey(
                        name: "FK_SubscriptionSupportedDevices_Subscriptions_SubscriptionsId",
                        column: x => x.SubscriptionsId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionSupportedDevices_SupportedDevices_SupportedDevicesId",
                        column: x => x.SupportedDevicesId,
                        principalTable: "SupportedDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCopyright = table.Column<bool>(type: "bit", nullable: false),
                    SubDocquyen = table.Column<bool>(type: "bit", nullable: false),
                    ChieuRap = table.Column<bool>(type: "bit", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EpisodeCurrent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EpisodeTotal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notify = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Showtimes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    View = table.Column<int>(type: "int", nullable: false),
                    Like = table.Column<int>(type: "int", nullable: false),
                    TmdbId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Createdid = table.Column<int>(type: "int", nullable: false),
                    Modifiedid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Created_Createdid",
                        column: x => x.Createdid,
                        principalTable: "Created",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_Modified_Modifiedid",
                        column: x => x.Modifiedid,
                        principalTable: "Modified",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_Tmbd_TmdbId",
                        column: x => x.TmdbId,
                        principalTable: "Tmbd",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NotifyMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotifyMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotifyMessages_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Otps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ExpireAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccounId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Otps_Accounts_AccounId",
                        column: x => x.AccounId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subscriptionHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptionHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subscriptionHistories_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_subscriptionHistories_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ActorFilm",
                columns: table => new
                {
                    Actorsid = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilm", x => new { x.Actorsid, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_ActorFilm_Actors_Actorsid",
                        column: x => x.Actorsid,
                        principalTable: "Actors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFilm",
                columns: table => new
                {
                    CategoriesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFilm", x => new { x.CategoriesId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_CategoryFilm_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryFilm",
                columns: table => new
                {
                    CountriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryFilm", x => new { x.CountriesId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_CountryFilm_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorFilm",
                columns: table => new
                {
                    DirectorsId = table.Column<int>(type: "int", nullable: false),
                    FilmsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorFilm", x => new { x.DirectorsId, x.FilmsId });
                    table.ForeignKey(
                        name: "FK_DirectorFilm_Directors_DirectorsId",
                        column: x => x.DirectorsId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorFilm_Films_FilmsId",
                        column: x => x.FilmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentEpisodeId = table.Column<int>(type: "int", nullable: true),
                    LastWatched = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WatchDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Histories_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Histories_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikedFilms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedFilms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedFilms_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LikedFilms_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servers_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WatchLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchLists_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchLists_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkEmbed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkM3U8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Servers_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Servers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "id", "AccountStat", "City", "Country", "Created", "Email", "LastUpdated", "Name", "PhoneNumber", "Region", "Role", "State", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), true, "Hanoi", "Vn", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "admin@gmail.com", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "Admin Person", "0123456789", "Sea", "Admin", "HN", "100000" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), true, "HCMC", "Vn", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "user1@gmail.com", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "User One", "0987654321", "Sea", "User", "HCM", "700000" },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), true, "Danang", "Vn", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "user2@gmail.com", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "User Two", "0911222333", "Sea", "User", "DN", "550000" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedDate", "MaxDownload", "MaxScreen", "MonthlyPrice", "Name", "Quality", "Resolution", "Type", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 1, 1, 74000, "Mobile", "Fair", "480p", "Mobile", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) },
                    { 2, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 1, 1, 114000, "Basic", "Good", "720p", "Basic", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) },
                    { 3, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 2, 2, 231000, "Standard", "Great", "1080 (Full HD)", "Standard", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) },
                    { 4, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 6, 4, 273000, "Prenium", "Best", "4k (Ultra HD) + HDR", "Prenium", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) }
                });

            migrationBuilder.InsertData(
                table: "SupportedDevices",
                columns: new[] { "Id", "DeviceName" },
                values: new object[,]
                {
                    { 1, "Mobile phone" },
                    { 2, "Tablet" },
                    { 3, "TV" },
                    { 4, "Computer" }
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountStat", "Created", "Email", "LastUpdated", "Password", "PersonId", "Role", "Status", "SubscriptionId", "UserName" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), true, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "admin@gmail.com", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "admin123", new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Admin", true, 1, "admin" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), true, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "user1@gmail.com", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "user123", new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "User", true, 2, "user1" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), true, new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "user2@gmail.com", new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "user123", new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "User", true, 3, "user2" }
                });

            migrationBuilder.InsertData(
                table: "subscriptionHistories",
                columns: new[] { "Id", "AccountId", "EndDate", "StartDate", "SubscriptionId", "SubscriptionMethod" },
                values: new object[,]
                {
                    { 1, new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 9, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 1, "" },
                    { 2, new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 9, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 2, "" },
                    { 3, new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 9, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), 3, "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PersonId",
                table: "Accounts",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SubscriptionId",
                table: "Accounts",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilm_FilmsId",
                table: "ActorFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilm_FilmsId",
                table: "CategoryFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryFilm_FilmsId",
                table: "CountryFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorFilm_FilmsId",
                table: "DirectorFilm",
                column: "FilmsId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_ServerId",
                table: "Episodes",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Createdid",
                table: "Films",
                column: "Createdid");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Modifiedid",
                table: "Films",
                column: "Modifiedid");

            migrationBuilder.CreateIndex(
                name: "IX_Films_TmdbId",
                table: "Films",
                column: "TmdbId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_AccountId",
                table: "Histories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_FilmId",
                table: "Histories",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedFilms_AccountId",
                table: "LikedFilms",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_LikedFilms_FilmId",
                table: "LikedFilms",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_NotifyMessages_AccountId",
                table: "NotifyMessages",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Otps_AccounId",
                table: "Otps",
                column: "AccounId");

            migrationBuilder.CreateIndex(
                name: "IX_Servers_FilmId",
                table: "Servers",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptionHistories_AccountId",
                table: "subscriptionHistories",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptionHistories_SubscriptionId",
                table: "subscriptionHistories",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionSupportedDevices_SupportedDevicesId",
                table: "SubscriptionSupportedDevices",
                column: "SupportedDevicesId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLists_AccountId",
                table: "WatchLists",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLists_FilmId",
                table: "WatchLists",
                column: "FilmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorFilm");

            migrationBuilder.DropTable(
                name: "CategoryFilm");

            migrationBuilder.DropTable(
                name: "CountryFilm");

            migrationBuilder.DropTable(
                name: "DirectorFilm");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "LikedFilms");

            migrationBuilder.DropTable(
                name: "NotifyMessages");

            migrationBuilder.DropTable(
                name: "Otps");

            migrationBuilder.DropTable(
                name: "subscriptionHistories");

            migrationBuilder.DropTable(
                name: "SubscriptionSupportedDevices");

            migrationBuilder.DropTable(
                name: "WatchLists");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Servers");

            migrationBuilder.DropTable(
                name: "SupportedDevices");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "Created");

            migrationBuilder.DropTable(
                name: "Modified");

            migrationBuilder.DropTable(
                name: "Tmbd");
        }
    }
}

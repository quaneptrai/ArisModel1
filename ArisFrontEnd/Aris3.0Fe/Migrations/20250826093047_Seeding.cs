using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aris3._0Fe.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "subscriptionHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "SubscriptionMethod" },
                values: new object[] { new DateTime(2025, 9, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), "Momo" });

            migrationBuilder.UpdateData(
                table: "subscriptionHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "SubscriptionMethod" },
                values: new object[] { new DateTime(2025, 9, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), "Visa" });

            migrationBuilder.UpdateData(
                table: "subscriptionHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "SubscriptionMethod" },
                values: new object[] { new DateTime(2025, 9, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 8, 26, 9, 30, 47, 287, DateTimeKind.Utc).AddTicks(3573), "Card" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "Created", "LastUpdated" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "subscriptionHistories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "SubscriptionMethod" },
                values: new object[] { new DateTime(2025, 9, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "" });

            migrationBuilder.UpdateData(
                table: "subscriptionHistories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "SubscriptionMethod" },
                values: new object[] { new DateTime(2025, 9, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "" });

            migrationBuilder.UpdateData(
                table: "subscriptionHistories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "SubscriptionMethod" },
                values: new object[] { new DateTime(2025, 9, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), new DateTime(2025, 8, 26, 9, 22, 2, 920, DateTimeKind.Utc).AddTicks(3327), "" });
        }
    }
}

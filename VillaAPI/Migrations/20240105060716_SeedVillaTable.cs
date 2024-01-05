using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8021), "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.", "", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8068), "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.", "", "Premium Pool Villa", 4, 300.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8071), "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.", "", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8073), "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.", "", "Diamond Villa", 4, 550.0, 900, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2024, 1, 5, 16, 37, 16, 352, DateTimeKind.Local).AddTicks(8076), "Donec massa sapien, pharetra eget semper vel, sagittis at mi. Sed euismod venenatis dictum. Donec at neque ut risus tincidunt malesuada ut ut enim. Vivamus vitae tincidunt leo. Integer eu.", "", "Diamond Pool Villa", 4, 600.0, 1100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

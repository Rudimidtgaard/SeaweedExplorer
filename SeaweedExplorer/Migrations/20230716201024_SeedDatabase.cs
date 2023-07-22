using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SeaweedExplorer.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SeeweedClass",
                columns: new[] { "Id", "NameCommon", "NameLatin" },
                values: new object[,]
                {
                    { 1, "Rødalge", "Chondrus crispus" },
                    { 2, "Brunalge", "Laminaria digitata" },
                    { 3, "Grønalge", "Ulva lactuca" }
                });

            migrationBuilder.InsertData(
                table: "Seeweed",
                columns: new[] { "Id", "NameCommon", "NameLatin", "Native", "SeeweedClassId" },
                values: new object[,]
                {
                    { 1, "Tarmrørhinde", "", true, 3 },
                    { 2, "Søl", "", true, 1 },
                    { 3, "Carrageentang", "", true, 1 },
                    { 4, "Gaffeltang", "", true, 1 },
                    { 5, "Fingertang", "", true, 2 },
                    { 6, "Sukkertang", "", true, 2 },
                    { 7, "Blæretang", "", true, 2 },
                    { 8, "Savtang", "", true, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seeweed",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SeeweedClass",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SeeweedClass",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SeeweedClass",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

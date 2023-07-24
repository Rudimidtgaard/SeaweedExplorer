using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SeaweedExplorer.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeaweedClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCommon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameLatin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeaweedClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seaweed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCommon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameLatin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Native = table.Column<bool>(type: "bit", nullable: false),
                    SeaweedClassId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seaweed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seaweed_SeaweedClass_SeaweedClassId",
                        column: x => x.SeaweedClassId,
                        principalTable: "SeaweedClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SeaweedClass",
                columns: new[] { "Id", "NameCommon", "NameLatin" },
                values: new object[,]
                {
                    { 1, "Rødalge", "Chondrus crispus" },
                    { 2, "Brunalge", "Laminaria digitata" },
                    { 3, "Grønalge", "Ulva lactuca" }
                });

            migrationBuilder.InsertData(
                table: "Seaweed",
                columns: new[] { "Id", "NameCommon", "NameLatin", "Native", "SeaweedClassId" },
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

            migrationBuilder.CreateIndex(
                name: "IX_Seaweed_SeaweedClassId",
                table: "Seaweed",
                column: "SeaweedClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seaweed");

            migrationBuilder.DropTable(
                name: "SeaweedClass");
        }
    }
}

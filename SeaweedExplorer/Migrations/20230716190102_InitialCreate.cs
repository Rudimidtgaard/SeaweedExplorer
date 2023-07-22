using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeaweedExplorer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeeweedClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCommon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameLatin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeeweedClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seeweed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCommon = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameLatin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Native = table.Column<bool>(type: "bit", nullable: false),
                    SeeweedClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seeweed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seeweed_SeeweedClass_SeeweedClassId",
                        column: x => x.SeeweedClassId,
                        principalTable: "SeeweedClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seeweed_SeeweedClassId",
                table: "Seeweed",
                column: "SeeweedClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Seeweed");

            migrationBuilder.DropTable(
                name: "SeeweedClass");
        }
    }
}

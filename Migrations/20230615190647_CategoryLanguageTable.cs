using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio_API.Migrations
{
    /// <inheritdoc />
    public partial class CategoryLanguageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category_LanguageId",
                table: "Langages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category_Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_Languages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Langages_Category_LanguageId",
                table: "Langages",
                column: "Category_LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Langages_Category_Languages_Category_LanguageId",
                table: "Langages",
                column: "Category_LanguageId",
                principalTable: "Category_Languages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Langages_Category_Languages_Category_LanguageId",
                table: "Langages");

            migrationBuilder.DropTable(
                name: "Category_Languages");

            migrationBuilder.DropIndex(
                name: "IX_Langages_Category_LanguageId",
                table: "Langages");

            migrationBuilder.DropColumn(
                name: "Category_LanguageId",
                table: "Langages");
        }
    }
}

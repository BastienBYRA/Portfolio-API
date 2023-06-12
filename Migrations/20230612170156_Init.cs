using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio_API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Experiences_ExperiencesId",
                table: "Missions");

            migrationBuilder.RenameColumn(
                name: "ExperiencesId",
                table: "Missions",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Missions_ExperiencesId",
                table: "Missions",
                newName: "IX_Missions_ProjectId");

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeriodId",
                table: "Experiences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearsStart = table.Column<int>(type: "int", nullable: false),
                    YearsEnd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Langages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Background = table.Column<bool>(type: "bit", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Langages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_ExperienceId",
                table: "Missions",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PeriodId",
                table: "Experiences",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Langages_ProjectId",
                table: "Langages",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Periods_PeriodId",
                table: "Experiences",
                column: "PeriodId",
                principalTable: "Periods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Experiences_ExperienceId",
                table: "Missions",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Projects_ProjectId",
                table: "Missions",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Periods_PeriodId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Experiences_ExperienceId",
                table: "Missions");

            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Projects_ProjectId",
                table: "Missions");

            migrationBuilder.DropTable(
                name: "Langages");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Missions_ExperienceId",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_PeriodId",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "PeriodId",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Missions",
                newName: "ExperiencesId");

            migrationBuilder.RenameIndex(
                name: "IX_Missions_ProjectId",
                table: "Missions",
                newName: "IX_Missions_ExperiencesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Experiences_ExperiencesId",
                table: "Missions",
                column: "ExperiencesId",
                principalTable: "Experiences",
                principalColumn: "Id");
        }
    }
}

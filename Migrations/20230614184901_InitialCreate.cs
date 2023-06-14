using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Langages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Background = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Langages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                });

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
                name: "Types_Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LangageProject",
                columns: table => new
                {
                    LangagesId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LangageProject", x => new { x.LangagesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_LangageProject_Langages_LangagesId",
                        column: x => x.LangagesId,
                        principalTable: "Langages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LangageProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissionProject",
                columns: table => new
                {
                    MissionsId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionProject", x => new { x.MissionsId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_MissionProject_Missions_MissionsId",
                        column: x => x.MissionsId,
                        principalTable: "Missions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img_Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type_ExperienceId = table.Column<int>(type: "int", nullable: false),
                    PeriodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiences_Types_Experiences_Type_ExperienceId",
                        column: x => x.Type_ExperienceId,
                        principalTable: "Types_Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExperienceMission",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false),
                    MissionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceMission", x => new { x.ExperienceId, x.MissionsId });
                    table.ForeignKey(
                        name: "FK_ExperienceMission_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExperienceMission_Missions_MissionsId",
                        column: x => x.MissionsId,
                        principalTable: "Missions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceMission_MissionsId",
                table: "ExperienceMission",
                column: "MissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PeriodId",
                table: "Experiences",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_Type_ExperienceId",
                table: "Experiences",
                column: "Type_ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_LangageProject_ProjectsId",
                table: "LangageProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionProject_ProjectsId",
                table: "MissionProject",
                column: "ProjectsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExperienceMission");

            migrationBuilder.DropTable(
                name: "LangageProject");

            migrationBuilder.DropTable(
                name: "MissionProject");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Langages");

            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Types_Experiences");
        }
    }
}

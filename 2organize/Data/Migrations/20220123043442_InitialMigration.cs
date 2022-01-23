using Microsoft.EntityFrameworkCore.Migrations;

namespace _2organize.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    FamilyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.FamilyId);
                });

            migrationBuilder.CreateTable(
                name: "HomeTasks",
                columns: table => new
                {
                    HomeTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeTasks", x => x.HomeTaskId);
                });

            migrationBuilder.CreateTable(
                name: "UserExtensions",
                columns: table => new
                {
                    UserExtensionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FamilyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExtensions", x => x.UserExtensionId);
                    table.ForeignKey(
                        name: "FK_UserExtensions_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "FamilyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssignedTasks",
                columns: table => new
                {
                    AssignedTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTaskId = table.Column<int>(nullable: true),
                    ResponsiblePersionUserExtensionId = table.Column<int>(nullable: true),
                    Done = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedTasks", x => x.AssignedTaskId);
                    table.ForeignKey(
                        name: "FK_AssignedTasks_HomeTasks_HomeTaskId",
                        column: x => x.HomeTaskId,
                        principalTable: "HomeTasks",
                        principalColumn: "HomeTaskId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssignedTasks_UserExtensions_ResponsiblePersionUserExtensionId",
                        column: x => x.ResponsiblePersionUserExtensionId,
                        principalTable: "UserExtensions",
                        principalColumn: "UserExtensionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disponibilities",
                columns: table => new
                {
                    DisponibilityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPeriodic = table.Column<bool>(nullable: false),
                    UserExtensionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilities", x => x.DisponibilityId);
                    table.ForeignKey(
                        name: "FK_Disponibilities_UserExtensions_UserExtensionId",
                        column: x => x.UserExtensionId,
                        principalTable: "UserExtensions",
                        principalColumn: "UserExtensionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignedTasks_HomeTaskId",
                table: "AssignedTasks",
                column: "HomeTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedTasks_ResponsiblePersionUserExtensionId",
                table: "AssignedTasks",
                column: "ResponsiblePersionUserExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilities_UserExtensionId",
                table: "Disponibilities",
                column: "UserExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExtensions_FamilyId",
                table: "UserExtensions",
                column: "FamilyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignedTasks");

            migrationBuilder.DropTable(
                name: "Disponibilities");

            migrationBuilder.DropTable(
                name: "HomeTasks");

            migrationBuilder.DropTable(
                name: "UserExtensions");

            migrationBuilder.DropTable(
                name: "Families");
        }
    }
}

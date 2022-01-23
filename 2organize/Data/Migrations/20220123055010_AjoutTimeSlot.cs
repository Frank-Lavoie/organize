using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2organize.Data.Migrations
{
    public partial class AjoutTimeSlot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeSlotId",
                table: "Disponibilities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeSlotId",
                table: "AssignedTasks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TimeSlot",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlot", x => x.TimeSlotId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilities_TimeSlotId",
                table: "Disponibilities",
                column: "TimeSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedTasks_TimeSlotId",
                table: "AssignedTasks",
                column: "TimeSlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedTasks_TimeSlot_TimeSlotId",
                table: "AssignedTasks",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "TimeSlotId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilities_TimeSlot_TimeSlotId",
                table: "Disponibilities",
                column: "TimeSlotId",
                principalTable: "TimeSlot",
                principalColumn: "TimeSlotId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedTasks_TimeSlot_TimeSlotId",
                table: "AssignedTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilities_TimeSlot_TimeSlotId",
                table: "Disponibilities");

            migrationBuilder.DropTable(
                name: "TimeSlot");

            migrationBuilder.DropIndex(
                name: "IX_Disponibilities_TimeSlotId",
                table: "Disponibilities");

            migrationBuilder.DropIndex(
                name: "IX_AssignedTasks_TimeSlotId",
                table: "AssignedTasks");

            migrationBuilder.DropColumn(
                name: "TimeSlotId",
                table: "Disponibilities");

            migrationBuilder.DropColumn(
                name: "TimeSlotId",
                table: "AssignedTasks");
        }
    }
}

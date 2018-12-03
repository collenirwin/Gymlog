using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class addinglogworkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoggedWorkouts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    WorkoutId = table.Column<string>(nullable: true),
                    NotesString = table.Column<string>(nullable: true),
                    RepsCompletedString = table.Column<string>(nullable: true),
                    WeightString = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoggedWorkouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoggedWorkouts");
        }
    }
}

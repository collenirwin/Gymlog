using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class addingworkout2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkoutExerciseId",
                table: "Set",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkoutExerciseId",
                table: "Set");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class addedexnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseNumber",
                table: "WorkoutExercises",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExerciseNumber",
                table: "WorkoutExercises");
        }
    }
}

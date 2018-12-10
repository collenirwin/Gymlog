using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class seedingWorkoutTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "Id", "Comments", "Reps", "SetNumber", "WorkoutExerciseId" },
                values: new object[,]
                {
                    { "1", "", 5, 1, "1" },
                    { "26", "", 5, 1, "6" },
                    { "25", "", 5, 5, "5" },
                    { "24", "", 5, 4, "5" },
                    { "23", "", 5, 3, "5" },
                    { "22", "", 5, 2, "5" },
                    { "21", "", 5, 1, "5" },
                    { "20", "", 5, 5, "4" },
                    { "19", "", 5, 4, "4" },
                    { "18", "", 5, 3, "4" },
                    { "16", "", 5, 1, "4" },
                    { "15", "", 5, 5, "3" },
                    { "14", "", 5, 4, "3" },
                    { "17", "", 5, 2, "4" },
                    { "12", "", 5, 2, "3" },
                    { "2", "", 5, 2, "1" },
                    { "3", "", 5, 3, "1" },
                    { "13", "", 5, 3, "3" },
                    { "5", "", 5, 5, "1" },
                    { "6", "", 5, 1, "2" },
                    { "4", "", 5, 4, "1" },
                    { "8", "", 5, 3, "2" },
                    { "9", "", 5, 4, "2" },
                    { "10", "", 5, 5, "2" },
                    { "11", "", 5, 1, "3" },
                    { "7", "", 5, 2, "2" }
                });

            migrationBuilder.InsertData(
                table: "WorkoutExercises",
                columns: new[] { "Id", "ExerciseName", "ExerciseNumber", "WorkoutId" },
                values: new object[,]
                {
                    { "5", "STANDING OVERHEAD BARBELL PRESS", 2, "2" },
                    { "1", "SQUAT", 1, "1" },
                    { "2", "FLAT BARBELL BENCH PRESS", 2, "1" },
                    { "3", "BENT OVER BARBELL ROWS", 3, "1" },
                    { "4", "SQUAT", 1, "2" },
                    { "6", "DEADLIFT", 3, "2" }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "1", "StrongLifts 5x5 A", null },
                    { "2", "StrongLifts 5x5 B", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "WorkoutExercises",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}

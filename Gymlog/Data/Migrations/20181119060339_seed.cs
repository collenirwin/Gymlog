using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ExerciseMuscle", "ExerciseName", "UserId" },
                values: new object[,]
                {
                    { "1", "CHEST", "FLAT BARBELL BENCH PRESS", null },
                    { "25", "SHOULDER", "STANDING OVERHEAD DUMBBELL PRESS", null },
                    { "26", "SHOULDER", "ARNOLD PRESS", null },
                    { "27", "SHOULDER", "DUMBBELL LATERAL RAISES", null },
                    { "28", "SHOULDER", "DUMBBELL FRONT RAISES", null },
                    { "29", "LEGS", "SQUAT", null },
                    { "30", "LEGS", "FRONT SQUATS", null },
                    { "31", "LEGS", "BARBELL LUNGES", null },
                    { "32", "LEGS", "DUMBBELL LUNGES", null },
                    { "33", "LEGS", "LEG PRESS", null },
                    { "34", "LEGS", "DEADLIFT", null },
                    { "35", "LEGS", "STRAIGHT LEG DEADLIFTS", null },
                    { "36", "LEGS", "SUMO DEADLIFTS", null },
                    { "37", "LEGS", "HYPEREXTENSIONS", null },
                    { "38", "LEGS", "GOOD-MORNINGS", null },
                    { "39", "LEGS", "LEG CURLS", null },
                    { "40", "TRICEPS", "TRICEP DIPS", null },
                    { "41", "TRICEPS", "FLAT CLOSE GRIP BENCH PRESS", null },
                    { "42", "TRICEPS", "SKULL CRUSHERS", null },
                    { "43", "BICEPS", "DUMBBELL CURLS", null },
                    { "24", "SHOULDER", "STANDING OVERHEAD BARBELL PRESS", null },
                    { "44", "BICEPS", "PREACHER CURLS", null },
                    { "23", "SHOULDER", "SEATED OVERHEAD DUMBBELL PRESS", null },
                    { "21", "BACK", "DUMBBELL SHRUGS", null },
                    { "2", "CHEST", "FLAT DUMBBELL BENCH PRESS", null },
                    { "3", "CHEST", "INCLINE BARBELL BENCH PRESS", null },
                    { "4", "CHEST", "INCLINE DUMBBELL BENCH PRESS", null },
                    { "5", "CHEST", "DECLINE BARBELL BENCH PRESS", null },
                    { "6", "CHEST", "DECLINE DUMBBELL BENCH PRESS", null },
                    { "7", "CHEST", "CHEST DIPS", null },
                    { "8", "CHEST", "PUSH-UPS", null },
                    { "9", "CHEST", "FLAT DUMBBELL FLYES", null },
                    { "10", "CHEST", "INCLINE DUMBBELL FLYES", null },
                    { "11", "CHEST", "DECLINE DUMBBELL FLYES", null },
                    { "12", "CHEST", "CABLE CROSSOVERS", null },
                    { "13", "BACK", "PULL-UPS", null },
                    { "14", "BACK", "CHIN-UPS", null },
                    { "15", "BACK", "LAT PULL-DOWNS", null },
                    { "16", "BACK", "BENT OVER BARBELL ROWS", null },
                    { "17", "BACK", "BENT OVER DUMBBELL ROWS", null },
                    { "18", "BACK", "T-BAR ROWS", null },
                    { "19", "BACK", "SEATED CABLE ROWS", null },
                    { "20", "BACK", "BARBELL SHRUGS", null },
                    { "22", "SHOULDER", "SEATED OVERHEAD BARBELL PRESS", null },
                    { "45", "BICEPS", "HAMMER CURLS", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: "9");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class addingworkout3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_WorkoutExericse_WorkoutExericseId",
                table: "Set");

            migrationBuilder.DropTable(
                name: "WorkoutExericse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set",
                table: "Set");

            migrationBuilder.DropIndex(
                name: "IX_Set_WorkoutExericseId",
                table: "Set");

            migrationBuilder.DropColumn(
                name: "WorkoutExericseId",
                table: "Set");

            migrationBuilder.RenameTable(
                name: "Set",
                newName: "Sets");

            migrationBuilder.AlterColumn<string>(
                name: "WorkoutExerciseId",
                table: "Sets",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sets",
                table: "Sets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "WorkoutExercises",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    WorkoutId = table.Column<string>(nullable: true),
                    ExerciseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutExercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutExercises_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sets_WorkoutExerciseId",
                table: "Sets",
                column: "WorkoutExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExercises_WorkoutId",
                table: "WorkoutExercises",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sets_WorkoutExercises_WorkoutExerciseId",
                table: "Sets",
                column: "WorkoutExerciseId",
                principalTable: "WorkoutExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sets_WorkoutExercises_WorkoutExerciseId",
                table: "Sets");

            migrationBuilder.DropTable(
                name: "WorkoutExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sets",
                table: "Sets");

            migrationBuilder.DropIndex(
                name: "IX_Sets_WorkoutExerciseId",
                table: "Sets");

            migrationBuilder.RenameTable(
                name: "Sets",
                newName: "Set");

            migrationBuilder.AlterColumn<string>(
                name: "WorkoutExerciseId",
                table: "Set",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkoutExericseId",
                table: "Set",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set",
                table: "Set",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "WorkoutExericse",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ExerciseName = table.Column<string>(nullable: true),
                    WorkoutId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutExericse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkoutExericse_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Set_WorkoutExericseId",
                table: "Set",
                column: "WorkoutExericseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutExericse_WorkoutId",
                table: "WorkoutExericse",
                column: "WorkoutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_WorkoutExericse_WorkoutExericseId",
                table: "Set",
                column: "WorkoutExericseId",
                principalTable: "WorkoutExericse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

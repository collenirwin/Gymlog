using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymlog.Data.Migrations
{
    public partial class addingworkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SetNumber = table.Column<int>(nullable: false),
                    Reps = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    WorkoutExericseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Set_WorkoutExericse_WorkoutExericseId",
                        column: x => x.WorkoutExericseId,
                        principalTable: "WorkoutExericse",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.DropTable(
                name: "WorkoutExericse");

            migrationBuilder.DropTable(
                name: "Workouts");
        }
    }
}

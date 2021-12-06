using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmEasy.Shared.Migrations
{
    public partial class LearningHistoriesAddIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LearningHistories_UserId",
                table: "LearningHistories");

            migrationBuilder.CreateIndex(
                name: "IX_LearningHistories_UserId_CourseId",
                table: "LearningHistories",
                columns: new[] { "UserId", "CourseId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LearningHistories_UserId_CourseId",
                table: "LearningHistories");

            migrationBuilder.CreateIndex(
                name: "IX_LearningHistories_UserId",
                table: "LearningHistories",
                column: "UserId");
        }
    }
}

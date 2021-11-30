using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmEasy.Shared.Migrations
{
    public partial class ProjectsAddIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId",
                table: "Projects");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId_ProjectName",
                table: "Projects",
                columns: new[] { "UserId", "ProjectName" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Projects_UserId_ProjectName",
                table: "Projects");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");
        }
    }
}

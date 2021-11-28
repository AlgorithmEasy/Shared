using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlgorithmEasy.Shared.Migrations
{
    public partial class ModifyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "varchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Projects",
                type: "datetime(6)",
                nullable: false)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "LearningHistories",
                type: "datetime(6)",
                nullable: false)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "Courses",
                type: "datetime(6)",
                nullable: false)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "LearningHistories");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldMaxLength: 30)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

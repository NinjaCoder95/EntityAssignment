using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1.Migrations
{
    public partial class add_year_remove_section : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "year_of_enrollment",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 2020);

            migrationBuilder.DropColumn(
                name: "Section",
                table: "Students");
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "year_of_enrollment",
                table: "Students");

            migrationBuilder.AddColumn<string>(
                name: "Section",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "NA");
        }
    }
}


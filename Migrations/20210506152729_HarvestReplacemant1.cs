using Microsoft.EntityFrameworkCore.Migrations;

namespace time_tracker.Migrations
{
    public partial class HarvestReplacemant1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Team",
                schema: "TimeTracker",
                table: "User",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Team",
                schema: "TimeTracker",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);
        }
    }
}

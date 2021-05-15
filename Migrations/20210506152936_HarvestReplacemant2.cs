using Microsoft.EntityFrameworkCore.Migrations;

namespace time_tracker.Migrations
{
    public partial class HarvestReplacemant2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "TimeTracker",
                table: "User",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "TimeTracker",
                table: "User",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);
        }
    }
}

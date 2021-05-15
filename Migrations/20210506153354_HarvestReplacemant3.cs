using Microsoft.EntityFrameworkCore.Migrations;

namespace time_tracker.Migrations
{
    public partial class HarvestReplacemant3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                schema: "TimeTracker",
                table: "User",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "CompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanySectionId",
                schema: "TimeTracker",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                schema: "TimeTracker",
                table: "User",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "CompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanySectionId",
                schema: "TimeTracker",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}

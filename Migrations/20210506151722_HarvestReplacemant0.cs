using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace time_tracker.Migrations
{
    public partial class HarvestReplacemant0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TimeTracker");

            migrationBuilder.CreateTable(
                name: "CompanySection",
                schema: "TimeTracker",
                columns: table => new
                {
                    CompanySectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanySectionName = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySection", x => x.CompanySectionId);
                });

            migrationBuilder.CreateTable(
                name: "CompanySubSection",
                schema: "TimeTracker",
                columns: table => new
                {
                    CompanySubSectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubSectionName = table.Column<string>(type: "varchar", nullable: false),
                    CompanySectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySubSection", x => x.CompanySubSectionId);
                    table.ForeignKey(
                        name: "FK_CompanySubSection_CompanySection_CompanySectionId",
                        column: x => x.CompanySectionId,
                        principalSchema: "TimeTracker",
                        principalTable: "CompanySection",
                        principalColumn: "CompanySectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTeam",
                schema: "TimeTracker",
                columns: table => new
                {
                    CompanySubSectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyTeamName = table.Column<string>(type: "varchar", nullable: false),
                    CompanySubSectionId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTeam", x => x.CompanySubSectionId);
                    table.ForeignKey(
                        name: "FK_CompanyTeam_CompanySubSection_CompanySubSectionId1",
                        column: x => x.CompanySubSectionId1,
                        principalSchema: "TimeTracker",
                        principalTable: "CompanySubSection",
                        principalColumn: "CompanySubSectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "TimeTracker",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar", nullable: true),
                    FirstName = table.Column<string>(type: " varchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: " varchar(30)", maxLength: 30, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    CompanySectionId = table.Column<int>(type: "int", nullable: false),
                    CompanySubSectionId = table.Column<int>(type: "int", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    CompanyTeamCompanySubSectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_CompanyTeam_CompanyTeamCompanySubSectionId",
                        column: x => x.CompanyTeamCompanySubSectionId,
                        principalSchema: "TimeTracker",
                        principalTable: "CompanyTeam",
                        principalColumn: "CompanySubSectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanySubSection_CompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                column: "CompanySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTeam_CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam",
                column: "CompanySubSectionId1");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyTeamCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                column: "CompanyTeamCompanySubSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "TimeTracker");

            migrationBuilder.DropTable(
                name: "CompanyTeam",
                schema: "TimeTracker");

            migrationBuilder.DropTable(
                name: "CompanySubSection",
                schema: "TimeTracker");

            migrationBuilder.DropTable(
                name: "CompanySection",
                schema: "TimeTracker");
        }
    }
}

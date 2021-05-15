using Microsoft.EntityFrameworkCore.Migrations;

namespace time_tracker.Migrations
{
    public partial class RenameModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanySubSection_CompanySection_CompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyTeam_CompanySubSection_CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_User_CompanyTeam_CompanyTeamCompanySubSectionId",
                schema: "TimeTracker",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_CompanyTeam_CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam");

            migrationBuilder.DropColumn(
                name: "CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam");

            migrationBuilder.RenameColumn(
                name: "CompanyTeamCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                newName: "CompanyTeamModelCompanySubSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_User_CompanyTeamCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                newName: "IX_User_CompanyTeamModelCompanySubSectionId");

            migrationBuilder.RenameColumn(
                name: "CompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                newName: "CompanySectionModelCompanySectionId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanySubSection_CompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                newName: "IX_CompanySubSection_CompanySectionModelCompanySectionId");

            migrationBuilder.AddColumn<int>(
                name: "CompanySubSectionModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "CompanyTeam",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTeam_CompanySubSectionModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "CompanyTeam",
                column: "CompanySubSectionModelCompanySubSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySubSection_CompanySection_CompanySectionModelCompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                column: "CompanySectionModelCompanySectionId",
                principalSchema: "TimeTracker",
                principalTable: "CompanySection",
                principalColumn: "CompanySectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyTeam_CompanySubSection_CompanySubSectionModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "CompanyTeam",
                column: "CompanySubSectionModelCompanySubSectionId",
                principalSchema: "TimeTracker",
                principalTable: "CompanySubSection",
                principalColumn: "CompanySubSectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_CompanyTeam_CompanyTeamModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                column: "CompanyTeamModelCompanySubSectionId",
                principalSchema: "TimeTracker",
                principalTable: "CompanyTeam",
                principalColumn: "CompanySubSectionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanySubSection_CompanySection_CompanySectionModelCompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyTeam_CompanySubSection_CompanySubSectionModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "CompanyTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_User_CompanyTeam_CompanyTeamModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_CompanyTeam_CompanySubSectionModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "CompanyTeam");

            migrationBuilder.DropColumn(
                name: "CompanySubSectionModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "CompanyTeam");

            migrationBuilder.RenameColumn(
                name: "CompanyTeamModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                newName: "CompanyTeamCompanySubSectionId");

            migrationBuilder.RenameIndex(
                name: "IX_User_CompanyTeamModelCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                newName: "IX_User_CompanyTeamCompanySubSectionId");

            migrationBuilder.RenameColumn(
                name: "CompanySectionModelCompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                newName: "CompanySectionId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanySubSection_CompanySectionModelCompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                newName: "IX_CompanySubSection_CompanySectionId");

            migrationBuilder.AddColumn<int>(
                name: "CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTeam_CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam",
                column: "CompanySubSectionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanySubSection_CompanySection_CompanySectionId",
                schema: "TimeTracker",
                table: "CompanySubSection",
                column: "CompanySectionId",
                principalSchema: "TimeTracker",
                principalTable: "CompanySection",
                principalColumn: "CompanySectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyTeam_CompanySubSection_CompanySubSectionId1",
                schema: "TimeTracker",
                table: "CompanyTeam",
                column: "CompanySubSectionId1",
                principalSchema: "TimeTracker",
                principalTable: "CompanySubSection",
                principalColumn: "CompanySubSectionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_CompanyTeam_CompanyTeamCompanySubSectionId",
                schema: "TimeTracker",
                table: "User",
                column: "CompanyTeamCompanySubSectionId",
                principalSchema: "TimeTracker",
                principalTable: "CompanyTeam",
                principalColumn: "CompanySubSectionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

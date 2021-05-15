using Microsoft.EntityFrameworkCore;
using time_tracker.Models;
 
namespace time_tracker.DataBase
{
    public class DataBaseContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public DataBaseContext(DbContextOptions options) : base(options) { }
        public DbSet<UserModel> Users {get;set;}
        public DbSet<CompanySectionModel> CompanySections {get;set;}
        public DbSet<CompanySubSectionModel> CompanySubSections {get;set;}
        public DbSet<CompanyTeamModel> CompanyTeams {get;set;}


    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_tracker.Models
{
    [Table("CompanyTeam", Schema = "TimeTracker")]
    public class CompanyTeamModel
    {
        [Key]
        public int CompanySubSectionId { get; set; }
        [Required]
        [Column("CompanyTeamName" ,TypeName = "varchar")]
        public string CompanyTeamName { get; set; }
        public List<UserModel> Users { get; set; }
    }
}
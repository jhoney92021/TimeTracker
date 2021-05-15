using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_tracker.Models
{
    [Table("CompanySubSection", Schema = "TimeTracker")]
    public class CompanySubSectionModel
    {
        [Key]
        public int CompanySubSectionId { get; set; }
        [Required]
        [Column("SubSectionName" ,TypeName = "varchar")]
        public string SubSectionName { get; set; }
        public List<CompanyTeamModel> Teams { get; set; }
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace time_tracker.Models
{
    [Table("CompanySection", Schema = "TimeTracker")]
    public class CompanySectionModel
    {
        [Key]
        public int CompanySectionId { get; set; }
        [Required]
        [Column("CompanySectionName" ,TypeName = "varchar")]
        public string CompanySectionName { get; set; }

        public List<CompanySubSectionModel> SubSections { get; set; }
    }
}
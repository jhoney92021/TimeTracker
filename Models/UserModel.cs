using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace time_tracker.Models
{
    [Table("User", Schema = "TimeTracker")]
    public class UserModel
    {
        #nullable enable

        [Column("UserName", TypeName = "varchar(30)")]
        public string? UserName {get; set;}

        #nullable disable

        [Key]
        public int UserId {get;set;}

        [Column("FirstName", TypeName = " varchar(30)")]
        [MaxLength(30)]
        [Display(Name = "Your First Name:")]
        public string FirstName {get;set;}

        [Column("LastName", TypeName = " varchar(30)")]
        [MaxLength(30)]
        [Display(Name = "Your Last Name:")]
        public string LastName {get;set;}

        [Column("EmailAddress", TypeName = "varchar(30)")]
        [MaxLength(30)]
        [Required]
        [Display(Name = "Your Email:")]
        public string EmailAddress {get;set;}

        public int? CompanySectionId {get; set;}

        public int? CompanySubSectionId {get; set;}

        [Column("Team", TypeName = "varchar(30)")]
        public string Team {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        [DataType(DataType.Password)]
        [Required] 
        [Display(Name = "Your Password:")]
        [Column("Password", TypeName = "varchar(200)")]
        [MinLength(3)]
        [MaxLength(200)]
        public string Password {get;set;}

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword{get;set;}
    }
}

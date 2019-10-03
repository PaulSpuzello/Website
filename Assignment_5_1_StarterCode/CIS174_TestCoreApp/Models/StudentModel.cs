using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace CIS174_TestCoreApp.Models
{
    public class StudentModel
    {
        [Required]
        [Display(Name = "Access Level:")]
        [Range(1, 10)]
        public int accessLevel { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(25)]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Grade")]
        [StringLength(25)]
        public string grade { get; set; }
    }
}

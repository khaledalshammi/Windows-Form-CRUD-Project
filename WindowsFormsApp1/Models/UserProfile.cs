using WindowsFormsApp1.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WindowsFormsApp1
{
    public class UserProfile
    {
        [Key]
        public int UserID { get; set; }
        [StringLength(50, ErrorMessage = "Full Name cannot exceed 50 characters.")]
        [Required, Display(Name = "Full Name")] //MaxLength(50)
        public string FullName { get; set; }
        [StringLength(50, ErrorMessage = "Email cannot exceed 50 characters.")]
        [EmailAddress, Required]
        public string Email { get; set; }
        [BirthDateNotInFuture, Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
    }
}

using DBEntityFrameWork.CustomValidation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBEntityFrameWork
{
    public class UserProfile
    {
        [Key]
        public int UserID { get; set; }
        [Required, MaxLength(50)]
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [BirthDateNotInFuture]
        [Required, Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        public int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
    }
}

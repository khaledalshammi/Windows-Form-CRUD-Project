using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WindowsFormsApp1
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        [Display(Name = "Department"), StringLength(50), Required]
        public string DeptName { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
    }
}

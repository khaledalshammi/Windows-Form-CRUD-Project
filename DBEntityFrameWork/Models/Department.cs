using System.ComponentModel.DataAnnotations;

namespace DBEntityFrameWork
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        [MaxLength(50)]
        public string DeptName { get; set; }
    }
}

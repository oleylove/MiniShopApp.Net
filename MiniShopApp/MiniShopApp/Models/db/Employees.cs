using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models.db
{
    public partial class Employees
    {
        public Employees()
        {
            Sales = new HashSet<Sales>();
        }

        public string EmpId { get; set; }
        public string EmpPassword { get; set; }
        public string EmpTitle { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public int EmpAge { get; set; }
        public DateTime EmpBirthday { get; set; }
        public string EmpPhon { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhoto { get; set; }
        public string EmpRole { get; set; }
        public string EmpState { get; set; }
        public DateTime? EmpCraete { get; set; }
        public DateTime? EmpUpdate { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}

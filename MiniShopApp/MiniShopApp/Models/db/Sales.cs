using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models.db
{
    public partial class Sales
    {
        public Sales()
        {
            SalesDtl = new HashSet<SalesDtl>();
        }

        public int SaleId { get; set; }
        public string EmpId { get; set; }
        public double SaleAmount { get; set; }
        public DateTime? SaleCreate { get; set; }
        public DateTime? SaleUpdate { get; set; }

        public virtual Employees Emp { get; set; }
        public virtual ICollection<SalesDtl> SalesDtl { get; set; }
    }
}

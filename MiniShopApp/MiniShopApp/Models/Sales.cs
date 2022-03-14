using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models
{
    public partial class Sales
    {
        public int SaleId { get; set; }
        public string EmpId { get; set; }
        public double SaleAmount { get; set; }
        public DateTime? SaleCraete { get; set; }
        public DateTime? SaleUpdate { get; set; }
    }
}

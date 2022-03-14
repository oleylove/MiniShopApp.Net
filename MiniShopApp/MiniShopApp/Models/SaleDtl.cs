using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models
{
    public partial class SaleDtl
    {
        public int SdtlId { get; set; }
        public int SaleId { get; set; }
        public string ProId { get; set; }
        public int SdtdlQty { get; set; }
        public double SdtlAmount { get; set; }
        public DateTime? SdtlCraete { get; set; }
        public DateTime? SdtlUpdate { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models.db
{
    public partial class SalesDtl
    {
        public int SdtId { get; set; }
        public int SaleId { get; set; }
        public string ProId { get; set; }
        public int SdtQty { get; set; }
        public double SdtAmount { get; set; }

        public virtual Products Pro { get; set; }
        public virtual Sales Sale { get; set; }
    }
}

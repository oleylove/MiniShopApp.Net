using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models.db
{
    public partial class Products
    {
        public Products()
        {
            SalesDtl = new HashSet<SalesDtl>();
        }

        public string ProId { get; set; }
        public string ProName { get; set; }
        public string ProSize { get; set; }
        public double ProCost { get; set; }
        public double ProPrice { get; set; }
        public int ProQty { get; set; }
        public string ProPhoto { get; set; }
        public string ProState { get; set; }
        public DateTime? ProCreate { get; set; }
        public DateTime? ProUpdate { get; set; }
        public int CatId { get; set; }
        public int ShfId { get; set; }

        public virtual Categories Cat { get; set; }
        public virtual Shelfs Shf { get; set; }
        public virtual ICollection<SalesDtl> SalesDtl { get; set; }
    }
}

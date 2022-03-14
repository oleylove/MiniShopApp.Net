using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models
{
    public partial class Product
    {
        public string ProId { get; set; }
        public int CatId { get; set; }
        public int ShfId { get; set; }
        public string ProName { get; set; }
        public string ProSize { get; set; }
        public double ProCost { get; set; }
        public double ProPrice { get; set; }
        public int ProQuantity { get; set; }
        public string ProPhoto { get; set; }
        public DateTime? ProCraete { get; set; }
        public DateTime? ProUpdate { get; set; }
    }
}

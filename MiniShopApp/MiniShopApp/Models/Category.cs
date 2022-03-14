using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models
{
    public partial class Category
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public DateTime? CatCreate { get; set; }
        public DateTime? CatUpdate { get; set; }
    }
}

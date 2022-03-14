using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models.db
{
    public partial class Shelfs
    {
        public Shelfs()
        {
            Products = new HashSet<Products>();
        }

        public int ShfId { get; set; }
        public string ShfName { get; set; }
        public DateTime? ShfCreate { get; set; }
        public DateTime? ShfUpdate { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}

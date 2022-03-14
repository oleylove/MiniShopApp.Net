using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MiniShopApp.Models
{
    public partial class Shelf
    {
        public int ShfId { get; set; }
        public string ShfName { get; set; }
        public string ShfNumber { get; set; }
        public DateTime? ShfCraete { get; set; }
        public DateTime? ShfUpdate { get; set; }
    }
}

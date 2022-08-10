using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication3
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }
        public int? Amt { get; set; }

        public virtual Products Product { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindWebAPI.Models
{
    public partial class Movementdetail
    {
        public int MovementId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Movement Movement { get; set; }
        public virtual Product Product { get; set; }
    }
}

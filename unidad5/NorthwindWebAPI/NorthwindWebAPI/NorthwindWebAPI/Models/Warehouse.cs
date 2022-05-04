using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindWebAPI.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            MovementOriginWarehouses = new HashSet<Movement>();
            MovementTargetWarehouses = new HashSet<Movement>();
            Warehouseproducts = new HashSet<Warehouseproduct>();
        }

        public int WarehouseId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Movement> MovementOriginWarehouses { get; set; }
        public virtual ICollection<Movement> MovementTargetWarehouses { get; set; }
        public virtual ICollection<Warehouseproduct> Warehouseproducts { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindWebAPI.Models
{
    public partial class Movement
    {
        public Movement()
        {
            Movementdetails = new HashSet<Movementdetail>();
        }

        public int MovementId { get; set; }
        public DateTime Date { get; set; }
        public int? SupplierId { get; set; }
        public int OriginWarehouseId { get; set; }
        public int? TargetWarehouseId { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Warehouse OriginWarehouse { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Warehouse TargetWarehouse { get; set; }
        public virtual ICollection<Movementdetail> Movementdetails { get; set; }
    }
}

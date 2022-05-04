using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindWebAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Movementdetails = new HashSet<Movementdetail>();
            Warehouseproducts = new HashSet<Warehouseproduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public double? UnitPrice { get; set; }
        public string PhotoPath { get; set; }
        public int CompanyId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Movementdetail> Movementdetails { get; set; }
        public virtual ICollection<Warehouseproduct> Warehouseproducts { get; set; }
    }
}

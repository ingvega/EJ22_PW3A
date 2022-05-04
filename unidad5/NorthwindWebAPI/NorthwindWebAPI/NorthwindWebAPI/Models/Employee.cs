using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindWebAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            InverseReportsToNavigation = new HashSet<Employee>();
            Movements = new HashSet<Movement>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public int? ReportsTo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Employee ReportsToNavigation { get; set; }
        public virtual ICollection<Employee> InverseReportsToNavigation { get; set; }
        public virtual ICollection<Movement> Movements { get; set; }
    }
}

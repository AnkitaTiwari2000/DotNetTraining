using System;
using System.Collections.Generic;

namespace LogInForm.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int EmployeeMob { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; } = null!;
    }
}

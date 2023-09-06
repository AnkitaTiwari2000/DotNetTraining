using System;
using System.Collections.Generic;

namespace LogInForm.Models
{
    public partial class Address
    {
        public Address()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string AddressName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

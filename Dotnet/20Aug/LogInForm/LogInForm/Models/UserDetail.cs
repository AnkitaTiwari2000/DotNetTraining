using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogInForm.Models
{
    public partial class UserDetail
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}

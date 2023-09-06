using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConrollerForContact.Models
{
    public class ContactVIewModel
    {
        public Guid Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
    }
}

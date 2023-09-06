using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string AddressName { get; set; } = string.Empty;

    }
}

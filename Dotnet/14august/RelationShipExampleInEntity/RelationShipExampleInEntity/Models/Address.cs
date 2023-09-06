using System.ComponentModel.DataAnnotations;

namespace RelationShipExampleInEntity.Models
{
    public class Address
    {

        [Key]
            public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string AddressName { get; set; }
          

           
        
    }
}

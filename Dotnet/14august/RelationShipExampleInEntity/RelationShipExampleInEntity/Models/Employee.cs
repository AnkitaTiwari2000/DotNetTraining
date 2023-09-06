using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RelationShipExampleInEntity.Models
{
    public class Employee
    {
       
            public int Id { get; set; }
        [RegularExpression("^[a-zA-Z ]*$")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(20,MinimumLength = 3)]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="number is Required")]
        [RegularExpression("([0-9]+)")]
        

        public int EmployeeMob { get; set; }
        public int addressId { get; set; }
        [ForeignKey("addressId")]
        public virtual  Address address { get; set; }

           
        

        
    }
}

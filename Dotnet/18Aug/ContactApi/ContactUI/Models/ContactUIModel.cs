using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ContactUI.Models
{
    public class ContactUIModel
    {
        
        public  Guid Id { get; set; }
       
        [DisplayName("Name")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Required(ErrorMessage = "Enter Username")]
        public string FullName { get; set; }
     
        [Required(ErrorMessage = "Enter Email")]

        [DataType(DataType.EmailAddress, ErrorMessage = "Enter Valid Email")]
        public string Email { get; set; }
       
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }
      
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        public string Address { get; set; }
    }
}

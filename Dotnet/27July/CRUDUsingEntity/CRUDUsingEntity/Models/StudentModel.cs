using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDUsingEntity.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is manadatry")]
        [StringLength (20,MinimumLength =5,ErrorMessage="Name IS Not In Right Length")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Email is Manadatry")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter correct email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Course is manadatry")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Course IS Not In Right Length")]
       
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage = "Course Must In String")]
        public string Course { get; set; }


        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateOFBirth { get; set; }
       
    }
}

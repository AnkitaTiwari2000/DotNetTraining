using System.ComponentModel.DataAnnotations;

namespace SimpleRepo.Models
{
    public class Stud
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace NewAjaxApi.Models
{
    public class ProductSam
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr{ get; set; }
        public double Price { get; set; }

    }
}

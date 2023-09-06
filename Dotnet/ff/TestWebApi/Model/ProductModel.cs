using System.ComponentModel.DataAnnotations;

namespace TestWebApi.Model
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public  decimal Price { get; set; }

        public int Qty { get; set; }
    }
}

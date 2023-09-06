namespace DemoForAjax.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Computer",Price=40000},
            new Product(){ProductId=2,ProductName="Laptop",Price=2330},
            new Product(){ProductId=3,ProductName="Mouse",Price=400},
            new Product(){ProductId=4,ProductName="KeyBoard",Price=30000}
        };
            return products;
        }
    }
}

namespace _21521003_ECommerce.Models
{

        public class User
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        }

        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Picture { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        }
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }

}

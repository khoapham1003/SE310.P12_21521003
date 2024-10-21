namespace BTH2_TheStore.Models
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

        }

}

namespace WebsiteQLSP.Models
{

        public class Catalog
        {
            public int CatalogId { get; set; }
            public string CatalogName { get; set; }
            public ICollection<Product> Products { get; set; }
        }

        public class Product
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal Price { get; set; }
            public string Picture { get; set; }
            public int CatalogId { get; set; }
            public Catalog Catalog { get; set; }
        }

}

namespace InventarioApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public string? ProductDescription { get; set; }

        public string? ProductCategory { get; set; }

        public int? Stock { get; set; }

        public double? Price { get; set;}

        public string? ExpirationDate { get; set; }
    }
}

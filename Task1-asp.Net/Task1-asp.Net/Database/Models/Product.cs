namespace Task1_asp.Net.Database.Models
{
    public class Product
    {

        public Product()
        {
            Id = ++DbContext._productId;
            

        }

        public Product(string name, string description, string color, string size, decimal price,DateTime creationDate)
        {
            Id = ++DbContext._productId;
            Name = name;
            Description = description;
            Color = color;
            Size = size;
            Price = price;
            CreationDate = creationDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        
        public DateTime CreationDate { get; set; }
    }
}

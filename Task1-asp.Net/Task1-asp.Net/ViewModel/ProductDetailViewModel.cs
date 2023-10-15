namespace Task1_asp.Net.ViewModel
{
    public class ProductDetailViewModel
    {
        public ProductDetailViewModel(string name, string description, string size, string color, int price)
        {
            Name = name;
            Description = description;
            Size = size;
            Color = color;
            Price = price;
        }

        public ProductDetailViewModel(int id)
        {
            id = Id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}



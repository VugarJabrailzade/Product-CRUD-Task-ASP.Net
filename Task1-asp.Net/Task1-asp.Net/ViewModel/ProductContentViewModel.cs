namespace Task1_asp.Net.ViewModel
{
    public class ProductContentViewModel
    {
        public ProductContentViewModel(int id, string name, string description, string size, string color, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Size = size;
            Color = color;
            Price = price;
            

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        
    }
}

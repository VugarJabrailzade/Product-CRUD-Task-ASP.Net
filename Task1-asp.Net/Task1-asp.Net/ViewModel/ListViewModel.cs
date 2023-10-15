namespace Task1_asp.Net.ViewModel
{
    public class ListViewModel
    {

        public ListViewModel(int id,string name, string description, decimal price, DateTime creationDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CreationDate = creationDate;
        }

        public ListViewModel(int id ,string name, string description, string size, string color, decimal price, DateTime creationDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Size = size;
            Color = color;
            Price = price;
            CreationDate = creationDate;
        }
       
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public DateTime CreationDate { get; set; }
    }
}

using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Database.Models
{
    public class sliderProduct
    {
        public sliderProduct()
        {
            Id = ++DbContext._sliderproductId;
        }

        public sliderProduct(string name, string description, int orderCount, int sale)
        {
            Id = ++DbContext._sliderproductId;
            Name = name;
            Description = description;
            OrderCount = orderCount;
            Sale = sale;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderCount { get; set; }
        public int Sale {  get; set; }
    }
}

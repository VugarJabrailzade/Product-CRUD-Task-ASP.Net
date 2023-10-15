using System.Xml.Linq;

namespace Task1_asp.Net.ViewModel
{
    public class SliderContent
    {

        public SliderContent(string name, string description, int sale)
        {
            Name = name;
            Description = description;
            Sale = sale;
        }

        public SliderContent(int id, string name, string description, int orderCount, int sale)
        {
            Id = id;
            Name = name;
            Description = description;
            OrderCount = orderCount;
            Sale = sale;
        }

        public int Id { get; set; }

        public int OrderCount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sale { get; set; }
    }
}

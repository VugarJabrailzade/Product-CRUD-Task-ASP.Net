namespace Task1_asp.Net.ViewModel
{
    public class AddViewModel
    {
        public AddViewModel()
        {
            Created = DateTime.Now;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }

        public int OrderCount { get; set; }
        public int Sale { get; set; }
        public DateTime Created { get; set; }

    }
}

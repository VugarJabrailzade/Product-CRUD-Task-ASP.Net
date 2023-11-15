namespace Task1_asp.Net.ViewModel
{
    public class NavbarViewModel
    {
        public NavbarViewModel(int id, string title, int orderCount, bool isHeader)
        {
            Id = id;
            Title = title;
            OrderCount = orderCount;
            IsHeader = isHeader;
        }

        public NavbarViewModel(string title)
        {
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int OrderCount { get; set; }
        public bool IsHeader { get; set; }

    }
}

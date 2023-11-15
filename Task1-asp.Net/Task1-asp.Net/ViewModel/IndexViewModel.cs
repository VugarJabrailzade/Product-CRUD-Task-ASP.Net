namespace Task1_asp.Net.ViewModel
{
    public class IndexViewModel
    {
        public IndexViewModel() { }

        public List<ListViewModel> ViewModels { get; set; }
        public List<SliderContent> sliderContentDetail { get; set; }     
        public List<NavbarViewModel> navbarViewModel { get; set; }
    }
}

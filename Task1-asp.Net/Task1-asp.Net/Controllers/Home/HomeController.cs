using Microsoft.AspNetCore.Mvc;
using Task1_asp.Net.Database;
using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Controllers.Home
{
    public class HomeController : Controller
    {
        
        public ViewResult Index()
        {
            var product = DbContext._product.Select(s => new ListViewModel(s.Id,s.Name, s.Description, s.Price)).ToList();
            var slider = DbContext._sliderProduct.Select(p => new SliderContent(p.Id,p.Name, p.Description,p.OrderCount, p.Sale)).
                                                    OrderBy(v=> v.OrderCount).ToList();

            IndexViewModel indexViewModel = new IndexViewModel();
            indexViewModel.ViewModels = product;
            indexViewModel.sliderContentDetail = slider;

            return View(indexViewModel);
        }
    }
}

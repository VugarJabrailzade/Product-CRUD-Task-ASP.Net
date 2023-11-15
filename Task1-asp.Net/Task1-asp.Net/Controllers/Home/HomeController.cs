using Microsoft.AspNetCore.Mvc;
using Task1_asp.Net.Database;
using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Controllers.Home
{
    public class HomeController : Controller
    {
        readonly PustokDbContext _pustokDbContext;

        public HomeController(PustokDbContext pustokDbContext)
        {
            _pustokDbContext = pustokDbContext;
        }

        public ViewResult Index()
        {


            var model = new IndexViewModel
            {
                ViewModels = DbContextCustom._product.Select(s => new ListViewModel(s.Id, s.Name, s.Description, s.Price, s.CreationDate)).ToList(),

                sliderContentDetail = DbContextCustom._sliderProduct.Select(p => new SliderContent(p.Id, p.Name, p.Description, p.OrderCount, p.Sale, p.ButtonLink)).
                                                     OrderBy(v => v.OrderCount).ToList(),

                navbarViewModel = _pustokDbContext.Navbars.OrderByDescending(p => p.OrderCount).Where(v=> v.IsHeader== true).
                                   Select(p => new NavbarViewModel(p.Title)).ToList()

            };
            return View(model);
        }
    }
}

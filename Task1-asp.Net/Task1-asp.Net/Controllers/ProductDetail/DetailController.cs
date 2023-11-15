using Microsoft.AspNetCore.Mvc;
using Task1_asp.Net.Database;
using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Controllers.ProductDetail
{
    [Route("product/detail")]
    public class DetailController : Controller
    {
        [HttpGet("list", Name ="content-list")]
        public IActionResult Index(int id)
        {
            var product = DbContextCustom._product.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}

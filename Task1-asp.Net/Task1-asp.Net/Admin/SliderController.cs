using Microsoft.AspNetCore.Mvc;
using Task1_asp.Net.Database;
using Task1_asp.Net.Database.Models;
using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Admin
{
    [Route("admin/slider")]
    public class SliderController : Controller
    {
        [HttpGet("list", Name ="product-slider")]
        public IActionResult sliderList()
        {
            var product = DbContext._sliderProduct.Select( s => new SliderContent(s.Id, s.Name,s.Description,s.OrderCount,s.Sale, s.ButtonLink)).ToList().
                                                   OrderBy( s => s.OrderCount ).ToList();
            

            return View(product);
        }

        [HttpGet("add", Name ="slider-add")]
        public IActionResult AddProductSlider() 
        {
            
            return View();
        }

        [HttpPost("add", Name = "slider-add")]
        public IActionResult AddProductSlider(AddViewModel model)
        {
            var product = new sliderProduct
            {
                Name = model.Name,
                Description = model.Description,
                Sale = model.Sale,
                OrderCount = model.OrderCount,
                
            };

            DbContext._sliderProduct.Add(product);

            return RedirectToRoute("product-slider");

        }

        [HttpGet("edit", Name ="edit-slider")]
        public IActionResult EditProductSlider(int id)
        {
            var product = DbContext._sliderProduct.FirstOrDefault(s => s.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost("edit", Name = "edit-slider")]
        public IActionResult EditProductSlider(SliderUpdateViewModel model)
        {
            var product = DbContext._sliderProduct.FirstOrDefault(x => x.Id == model.Id);
            
            if(product == null)
            {
                return NotFound();
            }

            product.Name = model.Name;
            product.Description = model.Description;
            product.Sale = model.Sale;
            product.OrderCount = model.OrderCount;
            product.ButtonLink = model.ButtonLink;

            return RedirectToRoute("product-slider");
        }

        [HttpGet("sliderdelete", Name ="slider-delete")]
        public IActionResult DeleteProductSlider(int id)
        {
            var product = DbContext._sliderProduct.FirstOrDefault(v => v.Id == id);
            if( product == null )
            {
                return NotFound();
            }

            DbContext._sliderProduct.Remove(product);
            return RedirectToRoute("product-slider");
        }


    }
}

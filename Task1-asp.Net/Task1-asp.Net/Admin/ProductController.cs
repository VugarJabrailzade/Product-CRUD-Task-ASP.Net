using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Task1_asp.Net.Database;
using Task1_asp.Net.Database.Models;
using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Admin
{
    [Route("admin/product")]
    public class AdminController : Controller
    {
        [HttpGet("list", Name = "product-list")]
        public IActionResult List()
        {
            var products = DbContext._product.Select(x => new ListViewModel(x.Id, x.Name, x.Description, x.Size, x.Color, x.Price, x.CreationDate)).ToList().
                                             OrderBy(x => x.CreationDate).ToList();
                                              
            
            return View(products);
        }

        [HttpGet("add", Name = "product-add")]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost("add", Name ="product-add")]
        public IActionResult AddProduct(AddViewModel model)
        {   
            
            var product =  new Product
            {
                Name = model.Name,
                Description = model.Description,
                Size = model.Size,
                Color = model.Color,
                Price = model.Price,
                CreationDate = model.Created,
                           
            };
            
            DbContext._product.Add(product);

            return RedirectToRoute("product-list");

        }

        [HttpGet("edit", Name ="product-edit")]
        public IActionResult EditProduct(int id)
        {
            var product = DbContext._product.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);

        }
        [HttpPost("edit", Name = "product-edit")]
        public IActionResult EditProduct(ProductUpdateViewModel model)
        {
            var product = DbContext._product.FirstOrDefault(x => x.Id == model.Id);
            if (product == null)
            {
                return NotFound();
            }
            
            product.Name = model.Name;
            product.Description = model.Description;
            product.Size = model.Size;
            product.Color = model.Color;
            product.Price = model.Price;

            return RedirectToRoute("product-list");

        }

        [HttpGet("delete",Name = "product-delete")]
        public IActionResult DeleteProduct(int id)
        {
            var product = DbContext._product.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            DbContext._product.Remove(product);
            return RedirectToRoute("product-list");

        }



    }
}

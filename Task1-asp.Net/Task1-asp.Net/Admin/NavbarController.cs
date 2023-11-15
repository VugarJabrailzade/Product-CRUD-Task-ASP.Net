using Microsoft.AspNetCore.Mvc;
using Npgsql;
using NpgsqlTypes;
using Task1_asp.Net.Database;
using Task1_asp.Net.Database.Models;
using Task1_asp.Net.ViewModel;

namespace Task1_asp.Net.Admin
{
    [Route("navbar")]
    public class NavbarController : Controller
    {
        readonly PustokDbContext _pustokDbContext;
        readonly ILogger<NavbarController> _logger;

        public NavbarController(PustokDbContext pustokDbContext,ILogger<NavbarController> logger)
        {
            _pustokDbContext = pustokDbContext;
            _logger = logger;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {

            var navbars = _pustokDbContext.Navbars.OrderByDescending(e => e.OrderCount)
                .Select(n => new NavbarViewModel(n.Id,n.Title, n.OrderCount, n.IsHeader)).ToList();
            return View("Views/Admin/Navbar/Index.cshtml", navbars);
        }

        #region Add
        [HttpGet ("add", Name = "navbar-add")]
        public IActionResult Add()
        {
            return View("Views/Admin/Navbar/Add.cshtml");
        }

        [HttpPost("add", Name = "navbar-add")]
        public IActionResult Add(AddNavbarViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var navbar = new Navbar
            {
                Title = model.Title,
                OrderCount = model.OrderCount,
                IsHeader = model.IsHeader
                

            };

            try
            {
                _pustokDbContext.Navbars.Add(navbar);
                _pustokDbContext.SaveChanges();
            }
            catch (PostgresException e)
            {
                _logger.LogError(e,"Postgresql Exception");
                throw e;
            }

            return RedirectToAction("index");
        }

        #endregion

        #region Edit

        [HttpGet("edit",Name ="navbar-edit")]
        public IActionResult Edit(int id)
        {
            if(!ModelState.IsValid) return View("index");

            Navbar navbars = _pustokDbContext.Navbars.FirstOrDefault(v =>  v.Id == id);
            
            if (navbars == null) return NotFound();


            var models = new NavbarUpdateViewModel()
            {
                Id = navbars.Id,
                Title = navbars.Title,
                OrderCount = navbars.OrderCount,
                IsHeader = navbars.IsHeader
            };

            return View("Views/Admin/Navbar/Edit.cshtml", models);

        }

        [HttpPost("edit",Name ="navbar-edit")]
        public IActionResult Edit(NavbarUpdateViewModel model)
        {
            if (!ModelState.IsValid) return View("index");

            Navbar navbar = _pustokDbContext.Navbars.FirstOrDefault(p =>p.Id == model.Id);
            if (navbar == null) return NotFound();

            navbar.Title = model.Title;
            navbar.OrderCount = model.OrderCount;
            navbar.IsHeader = model.IsHeader;

            try
            {
                _pustokDbContext.Update(navbar);
                _pustokDbContext.SaveChanges();
            }
            catch (PostgresException ex)
            {
                _logger.LogError(ex, "Postgre Exception");
                throw ex;
            }

            return RedirectToAction("index");

        }

        #endregion 


        #region Delete
        [HttpGet("navbar-delete", Name = "navbar-delete")]
        public IActionResult RemoveNavbar(int id)
        {
            if (!ModelState.IsValid) return View("index");

            Navbar navbars = _pustokDbContext.Navbars.FirstOrDefault(p => p.Id == id);

            if (navbars == null) return NotFound();

            _pustokDbContext.Navbars.Remove(navbars);
            _pustokDbContext.SaveChanges();

            return RedirectToAction("index");
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            _pustokDbContext.Dispose();
            base.Dispose(disposing);
        }
    }
}

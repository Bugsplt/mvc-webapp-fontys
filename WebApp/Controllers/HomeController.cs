using System.Collections.Generic;
using System.Threading;
using InterfaceLayer.DTO;
using LogicLayer;
using LogicLayer.Classes;
using LogicLayer.Containers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppProftS2.Models;
using Activity = System.Diagnostics.Activity;

namespace WebAppProftS2.Controllers
{
    public class HomeController : Controller
    {
        private Factory _factory = new();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Dashboard()
        {
            _factory.CustomerContainer.Load();
            _factory.ProspectContainer.Load();
            return View(new ContactView(_factory.CustomerContainer.GetCustomers(), _factory.ProspectContainer.GetProspects()));
        }
        
        [HttpGet]
        public IActionResult CustomerView(string id)
        {
            return View(new CustomerDetails(_factory.CustomerContainer.LoadCustomer(id)));
        }
        
        [HttpPost]
        public IActionResult CustomerView(CustomerDetails details) 
        {
            var areas = new List<AreaDTO>();
            areas.Add(new AreaDTO() {
                FbAdId = details.FbAdId,
                IgAdId = details.InstaAdId
            });
            
            var searches = new List<SearchDTO>();
            searches.Add(new SearchDTO() {
                _areas = areas,
                CatName = details.CatName,
                FbPostId = details.FbPostId,
                IgPostId = details.InstaPostId
            });
            
            _factory.CustomerContainer.Update(new CustomerDTO() {
                Id = details.Id,
                FirstName = details.Name,
                Email = details.Email,
                Status = details.Status.ToString(),
                Language = details.Language,
                Country = details.Country,
                PhoneNr = details.Phone,
                _searches = searches
            });

            //todo  
            Thread.Sleep(50);
            return RedirectToAction("CustomerView","Home",details.Id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [HttpGet]
        public IActionResult DeleteCustomer(string id)
        {
            _factory.CustomerContainer.Remove(new CustomerDTO() {
                Id = id
            });
            
            Thread.Sleep(50);
            return RedirectToAction("Dashboard","Home");
        }
        
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View(new CustomerDetails());
        }
        
        [HttpPost]
        public IActionResult CreateCustomer(CustomerDetails details) 
        {
            var areas = new List<AreaDTO>();
            areas.Add(new AreaDTO() {
                FbAdId = details.FbAdId,
                IgAdId = details.InstaAdId
            });
            
            var searches = new List<SearchDTO>();
            searches.Add(new SearchDTO() {
                _areas = areas,
                CatName = details.CatName,
                FbPostId = details.FbPostId,
                IgPostId = details.InstaPostId
            });
            
            var id = _factory.CustomerContainer.Create(new CustomerDTO() {
                FirstName = details.Name,
                Email = details.Email,
                Status = details.Status.ToString(),
                Language = details.Language,
                Country = details.Country,
                PhoneNr = details.Phone,
                _searches = searches
            });

            //todo  
            Thread.Sleep(50);
            return RedirectToAction("CustomerView","Home",new {id});   
        }
    }
}
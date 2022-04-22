using System.Diagnostics;
using InterfaceLayer.DTO;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppProftS2.Models;

namespace WebAppProftS2.Controllers
{
    public class HomeController : Controller
    {
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
            Toolbox.CustomerViewHelper.LoadCustomerView();
            var model = new ContactView(Toolbox.CustomerContainer.GetCustomers(), Toolbox.ProspectContainer.GetProspects());
            return View(model);
        }
        
        [HttpGet]
        public IActionResult CustomerView(string id)
        {
            var token = Toolbox.CustomerDetailsHelper.LoadCustomerDetailView(id);
            var model = token.ToObject<CustomerDetails>();
            return View(model);
        }
        
        [HttpPost]
        public void CustomerView(CustomerDetails details)
        {
            Toolbox.CustomerDetailsHelper.UpdateCustomerDetails(new CustomerDTO());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
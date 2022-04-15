using System.Diagnostics;
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
            Toolbox.CustomerDetailsHelper.UpdateCustomerDetails(Toolbox.ToDto(details.Name,details.Activity,details.Searches,details.CatName,details.Country,details.Phone,details.Email,details.Status.ToString(),details.Notes,details.Tasks,details.Orders,details.Tips,details.FbAdId,details.FbPostId,details.Id,details.InstaAdId,details.InstaPostId,details.Language));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
using System;
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

        // public IActionResult Privacy()
        // {
        //     return View();
        // }
        
        public IActionResult Dashboard()
        {
            _factory.CustomerContainer.Load();
            _factory.ProspectContainer.Load();
            return View(new ContactView(_factory.CustomerContainer.GetCustomers(), _factory.ProspectContainer.GetProspects()));
        }
        
        [HttpGet]
        public IActionResult CustomerView(string id)
        {
            var details = new CustomerDetails(_factory.CustomerContainer.LoadCustomer(id));
            return View(details);
        }
        
        [HttpPost]
        public IActionResult CustomerView(CustomerDetails details) 
        {
            if (details.Email == null)
            {
                return RedirectToAction("CustomerView","Home",new{id=details.Id, errorMessage="Email is required"});
            }

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

            try
            {
                _factory.CustomerContainer.Update(new CustomerDTO()
                {
                    Id = details.Id,
                    FirstName = details.Name,
                    Email = details.Email,
                    Status = details.Status.ToString(),
                    Language = details.Language,
                    Country = details.Country,
                    PhoneNr = details.Phone,
                    _searches = searches
                });
            } 
            catch (Exception e)
            {
                if (e.Message == "email already exists")
                {
                    details.ErrorMessage = "Email must be unique";
                    return RedirectToAction("CustomerView","Home",new{id = details.Id});
                }
                else
                {
                }
            }
            
            
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
        public IActionResult CreateCustomer(string errorDetails, string name, string email, string status, string language, string country, string phone, string fbAdId, string instaAdId, string catName, string fbPostId, string instaPostId)
        {
            if (errorDetails != null)
            {
                return View(new CustomerDetails() {
                    ErrorMessage = errorDetails,
                    Name = name,
                    Email = email,
                    Status = Enum.Parse<CustomerStatus>(status),
                    Language = language,
                    Country = country,
                    Phone = phone,
                    FbAdId = fbAdId,
                    InstaAdId = instaAdId,
                    CatName = catName,
                    FbPostId = fbPostId,
                    InstaPostId = instaPostId
                });
            }
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
            var id = 0;
            try
            {
                id = _factory.CustomerContainer.Create(new CustomerDTO()
                {
                    FirstName = details.Name,
                    Email = details.Email,
                    Status = details.Status.ToString(),
                    Language = details.Language,
                    Country = details.Country,
                    PhoneNr = details.Phone,
                    _searches = searches
                });
            } 
            catch (Exception e)
            {
                if (e.Message == "email already exists")
                {
                    return RedirectToAction("CreateCustomer","Home",new {
                        errorDetails = "Email must be unique", 
                        details.Name,
                        details.Email,
                        Status = details.Status.ToString(),
                        details.Language,
                        details.Country,
                        details.Phone,
                        details.FbAdId,
                        details.InstaAdId,
                        details.CatName,
                        details.FbPostId,
                        details.InstaPostId
                    });
                }
                else if (e.Message == "No email given")
                {
                    return RedirectToAction("CreateCustomer","Home",new {
                        errorDetails = "Email is required", 
                        details.Name,
                        details.Email,
                        Status = details.Status.ToString(),
                        details.Language,
                        details.Country,
                        details.Phone,
                        details.FbAdId,
                        details.InstaAdId,
                        details.CatName,
                        details.FbPostId,
                        details.InstaPostId
                    });
                }
                else
                {
                    throw;
                }
            }
            
            //todo  
            Thread.Sleep(50);
            return RedirectToAction("CustomerView","Home",new {id});   
        }
    }
}
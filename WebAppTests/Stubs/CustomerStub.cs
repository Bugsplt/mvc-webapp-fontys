using System.Collections.Generic;
using InterfaceLayer.DTO;
using LogicLayer.Classes;

namespace WebAppProftS2Tests.Stubs
{
    public class CustomerStub
    {
        public List<CustomerDTO> Customers;
        

        public CustomerStub()
        {
            SearchStub searchStub = new();
            ActivityStub activityStub = new();
            
            Customers = new List<CustomerDTO>
            {
                new()
                {
                    LastName = "LastName1",
                    FirstName = "FirstName",
                    Language = "Language1",
                    Country = "Country1",
                    PhoneNr = "PhoneNr1",
                    Email = "Email1",
                    Status = "Status1",
                    Id = "1",
                    _searches = new List<SearchDTO>{searchStub.Searches[0]},
                    _activities = new List<ActivityDTO>{activityStub.Activities[0]}
                },
                new()
                {
                    LastName = "LastNam2",
                    FirstName = "FirstName2",
                    Language = "Language2",
                    Country = "Country2",
                    PhoneNr = "PhoneNr2",
                    Email = "Email2",
                    Status = "Status2",
                    Id = "2",
                    _searches = new List<SearchDTO>{searchStub.Searches[1]},
                    _activities = new List<ActivityDTO>{activityStub.Activities[1]}
                },
                new()
                {
                    LastName = "LastName3",
                    FirstName = "FirstName3",
                    Language = "Language3",
                    Country = "Country3",
                    PhoneNr = "PhoneNr3",
                    Email = "Email3",
                    Status = "Status3",
                    Id = "3",
                    _searches = new List<SearchDTO>{searchStub.Searches[2]},
                    _activities = new List<ActivityDTO>{activityStub.Activities[2]}
                }
            };
        }
    }
}
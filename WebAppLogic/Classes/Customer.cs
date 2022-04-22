using System.Collections.Generic;
using InterfaceLayer.DTO;
using Newtonsoft.Json.Linq;
using WebAppDAL;

namespace LogicLayer.Classes
{
     public class Customer
     {
          public string LastName { get; private set; }
          public string FirstName { get; private set; }
          public string Language { get; private set; }
          public string Country { get; private set; }
          public string PhoneNr { get; private set; }
          public string Email { get; private set; }
          public string Id { get; private set; }

          public string Status;
          
          private List<Search> _searches = new();
          private List<Activity> _activities = new();

          public Customer(CustomerDTO dto)
          {
               var activities = new List<Activity>();
               foreach (var activity in dto._activities)
               {
                    activities.Add(new Activity(activity));
               }

               var searches = new List<Search>();
               foreach (var search in dto._searches)
               {
                    searches.Add(new Search(search));
               }
               
               LastName = dto.LastName;
               _activities = activities;
               FirstName = dto.FirstName;
               _searches = searches;
               Country = dto.Country;
               Email = dto.Email;
               Id = dto.Id;
               Language = dto.Language;
               PhoneNr = dto.PhoneNr;
               Status = dto.Status;

          }

          public Customer()
          {
            
          }
          
          public IReadOnlyList<Search> GetSearches()
          {
               return _searches;
          }

          public IReadOnlyList<Activity> GetActivities()
          {
               return _activities;
          }

          public void SetLanguage(string language)
          {
               Language = language;
          }

          public void SetCountry(string country)
          {
               Country = country;
          }

          public void SetPhoneNr(string phoneNr)
          {
               PhoneNr = phoneNr;
          }

          public void SetEmail(string email)
          {
               Email = email;
          }

          public void SetFirstName(string firstName)
          {
               FirstName = firstName;
          }

          public void SetLastName(string lastName)
          {
               LastName = lastName;
          }

          public void AddSearch(Search search)
          {
               _searches.Add(search);
          }

          public void RemoveSearch(Search search)
          {
               _searches.Remove(search);
          }

          public void AddActivity(Activity activity)
          {
               _activities.Add(activity);
          }

          public void RemoveActivity(Activity activity)
          {
               _activities.Remove(activity);
          }

          public void Clear()
          {
               _searches.Clear();
               _activities.Clear();
          }

          public CustomerDTO ToDto()
          {
               var activityDtos = new List<ActivityDTO>();
               foreach (var activity in _activities)
               {
                    activityDtos.Add(activity.ToDto());
               }

               var searchDtos = new List<SearchDTO>();
               foreach (var search in _searches)
               {
                    searchDtos.Add(search.ToDto());
               }


               return new CustomerDTO()
               {
                    LastName = LastName,
                    _activities = activityDtos,
                    FirstName = FirstName,
                    _searches = searchDtos,
                    Country = Country,
                    Email = Email,
                    Id = Id,
                    Language = Language,
                    PhoneNr = PhoneNr,
                    Status = Status
               };
          }

     }
}
using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using Newtonsoft.Json.Linq;

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

          public string Status { get; private set; }
          
          private List<Search> _searches = new();
          private List<Activity> _activities = new();

          public Customer(CustomerDTO dto)
          {
               if (dto._activities != null)
               {
                    var activities = new List<Activity>();
                    foreach (var activity in dto._activities)
                    {
                         activities.Add(new Activity(activity));
                    }
                    _activities = activities;
               }

               if (dto._searches != null)
               {
                    var searches = new List<Search>();
                    foreach (var search in dto._searches)
                    {
                         searches.Add(new Search(search));
                    }
                    _searches = searches;
               }

               LastName = dto.LastName;
               FirstName = dto.FirstName;
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
               foreach (var s in _searches)
               {
                    if (s.FbPostId == search.FbPostId)
                    {
                         throw new ArgumentException("Search already exists");
                    }
               }
               _searches.Add(search);
          }

          public void RemoveSearch(Search search)
          {
               foreach (var search1 in _searches)
               {
                    if  (search1.FbPostId == search.FbPostId)
                    {
                         _searches.Remove(search);
                         return;
                    }
               }
               throw new ArgumentException("Search not found");
          }

          public void AddActivity(Activity activity)
          {
               foreach (var activity1 in _activities)
               {
                    if (activity1.Date == activity.Date)
                    {
                         throw new ArgumentException("Activity already exists");
                    }
               }

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
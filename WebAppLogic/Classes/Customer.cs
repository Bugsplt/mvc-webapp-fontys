using System.Collections.Generic;

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

          public Customer(string firstName, string email, string phoneNr, string id)
          {
               FirstName = firstName;
               Email = email;
               PhoneNr = phoneNr;
               Id = id;
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

          public void Load()
          {
               //todo get this customers searches from api and set them to _searches
               //todo get this customers activity from api and set them to _activities
          }

          public void Clear()
          {
               _searches.Clear();
               _activities.Clear();
          }

     }
}
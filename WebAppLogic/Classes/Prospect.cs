using System.Collections.Generic;

namespace LogicLayer.Classes
{
    public class Prospect
    {
        public string CatName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNr { get; private set; }
        public string Country { get; private set; }
        public string Language { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string CatImg { get; private set; }
        public string MockupImg { get; private set; }
        public string PostMssg { get; private set; }
        public float Lat { get; private set; }
        public float Lng { get; private set; }

        private string _prospectNr;
        private List<Activity> _activities;

        public void SetCatName(string catName)
        {
            CatName = catName;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetPhoneNr(string phoneNr)
        {
            PhoneNr = phoneNr;
        }

        public void SetCountry(string country)
        {
            Country = country;
        }

        public void SetLanguage(string language)
        {
            Language = language;
        }

        public void SetCity(string city)
        {
            City = city;
        }

        public void SetStreet(string street)
        {
            Street = street;
        }

        public void SetCatImg(string catImg)
        {
            CatImg = catImg;
        }

        public void SetMockupImg(string mockupImg)
        {
            MockupImg = mockupImg;
        }

        public void SetPostMssg(string postMssg)
        {
            PostMssg = postMssg;
        }

        public void SetLat(float lat)
        {
            Lat = lat;
        }

        public void SetLng(float lng)
        {
            Lng = lng;
        }

        public void Add(Activity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(Activity activity)
        {
            _activities.Remove(activity);
        }

        public void Load()
        {
            //todo get this prospects activity from api and set it to _activities
        }

        public void Clear()
        {
            _activities.Clear();
        }
    }
}
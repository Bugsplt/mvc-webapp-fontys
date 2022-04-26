using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;

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
        public string ProspectNr { get; private set; }

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

        public Prospect(string catname, string email, string phoneNr, string prospectNr)
        {
            CatName = catname;
            Email = email;
            PhoneNr = phoneNr;
            ProspectNr = prospectNr;
        }
        
        public Prospect(){}

        public Prospect(ProspectDTO dto)
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

            CatName = dto.CatName;
            CatImg = dto.CatImg;
            City = dto.City;
            Country = dto.Country;
            Email = dto.Email;
            Language = dto.Language;
            Lat = dto.Lat;
            Lng = dto.Lng;
            MockupImg = dto.MockupImg;
            PostMssg = dto.PostMssg;
            ProspectNr = dto.ProspectNr;
            PhoneNr = dto.PhoneNr;
            Street = dto.Street;
        }
        
        public ProspectDTO ToDto()
        {
            var activityDtos = new List<ActivityDTO>();
            foreach (var activity in _activities)
            {
                activityDtos.Add(activity.ToDto());
            }

            return new ProspectDTO()
            {
                CatName = CatName,
                _activities = activityDtos,
                CatImg = CatImg,
                City = City,
                Country = Country,
                Email = Email,
                Language = Language,
                Lat = Lat,
                Lng = Lng,
                MockupImg = MockupImg,
                PostMssg = PostMssg,
                ProspectNr = ProspectNr,
                PhoneNr = PhoneNr,
                Street = Street
            };
        }
        
    }
}
using System.Collections.Generic;
using System.Linq;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    
    [TestClass]
    public class ProspectTest
    {
        [TestMethod]
        public void SetCatName_ShouldSetCatName()
        {
            // Arrange
            var prospect = new Prospect();
            var catName = "Test";

            // Act
            prospect.SetCatName(catName);

            // Assert
            Assert.AreEqual(catName, prospect.CatName);
        }
        
        [TestMethod]
        public void SetEmail_ShouldSetEmail()
        {
            // Arrange
            var prospect = new Prospect();
            var email = "Test";

            // Act
            prospect.SetEmail(email);

            // Assert
            Assert.AreEqual(email, prospect.Email);
        }
        
        [TestMethod]
        public void SetPhoneNr_ShouldSetPhoneNr()
        {
            // Arrange
            var prospect = new Prospect();
            var phoneNr = "Test";

            // Act
            prospect.SetPhoneNr(phoneNr);

            // Assert
            Assert.AreEqual(phoneNr, prospect.PhoneNr);
        }
        
        [TestMethod]
        public void SetCountry_ShouldSetCountry()
        {
            // Arrange
            var prospect = new Prospect();
            var country = "Test";

            // Act
            prospect.SetCountry(country);

            // Assert
            Assert.AreEqual(country, prospect.Country);
        }
       
        [TestMethod]
        public void SetLanguage_ShouldSetLanguage()
        {
            // Arrange
            var prospect = new Prospect();
            var language = "Test";

            // Act
            prospect.SetLanguage(language);

            // Assert
            Assert.AreEqual(language, prospect.Language);
        }
        
        [TestMethod]
        public void SetCity_ShouldSetCity()
        {
            // Arrange
            var prospect = new Prospect();
            var city = "Test";

            // Act
            prospect.SetCity(city);

            // Assert
            Assert.AreEqual(city, prospect.City);
        }
        
        [TestMethod]
        public void SetStreet_ShouldSetStreet()
        {
            // Arrange
            var prospect = new Prospect();
            var street = "Test";

            // Act
            prospect.SetStreet(street);

            // Assert
            Assert.AreEqual(street, prospect.Street);
        }
        
        [TestMethod]
        public void SetCatImg_ShouldSetCatImg()
        {
            // Arrange
            var prospect = new Prospect();
            var catImg = "Test";

            // Act
            prospect.SetCatImg(catImg);

            // Assert
            Assert.AreEqual(catImg, prospect.CatImg);
        }
        
        [TestMethod]
        public void SetMockupImg_ShouldSetMockupImg()
        {
            // Arrange
            var prospect = new Prospect();
            var mockupImg = "Test";

            // Act
            prospect.SetMockupImg(mockupImg);

            // Assert
            Assert.AreEqual(mockupImg, prospect.MockupImg);
        }
        
        [TestMethod]
        public void SetPostMssg_ShouldSetPostMssg()
        {
            // Arrange
            var prospect = new Prospect();
            var postMssg = "Test";

            // Act
            prospect.SetPostMssg(postMssg);

            // Assert
            Assert.AreEqual(postMssg, prospect.PostMssg);
        }
        
        [TestMethod]
        public void SetLat_ShouldSetLat()
        {
            // Arrange
            var prospect = new Prospect();
            var lat = 1.0f;

            // Act
            prospect.SetLat(lat);

            // Assert
            Assert.AreEqual(lat, prospect.Lat);
        }
        
        [TestMethod]
        public void SetLng_ShouldSetLng()
        {
            // Arrange
            var prospect = new Prospect();
            var lng = 1.0f;

            // Act
            prospect.SetLng(lng);

            // Assert
            Assert.AreEqual(lng, prospect.Lng);
        }
        
        [TestMethod]
        public void Add_ShouldAddActivity()
        {
            // Arrange
            var prospect = new Prospect();
            var activity = new Activity();

            // Act
            prospect.Add(activity);

            // Assert
            Assert.AreEqual(activity, prospect.GetActivities().ToList()[0]);
        }
       
        [TestMethod]
        public void Remove_ShouldRemoveActivity()
        {
            // Arrange
            var prospect = new Prospect();
            var activity = new Activity();
            prospect.Add(activity);

            // Act
            prospect.Remove(activity);

            // Assert
            Assert.AreEqual(0, prospect.GetActivities().Count);
        }
        
        [TestMethod]
        public void Load_ShouldLoadProspect()
        {
            // Arrange
            var prospect = new Prospect();
            var activity = new Activity();
            prospect.Add(activity);

            // Act
            prospect.Load();

            // Assert
            Assert.AreEqual(1, prospect.GetActivities().Count);
        }
        
        [TestMethod]
        public void Clear_ShouldClearProspect()
        {
            // Arrange
            var prospect = new Prospect();
            var activity = new Activity();
            prospect.Add(activity);

            // Act
            prospect.Clear();

            // Assert
            Assert.AreEqual(0, prospect.GetActivities().Count);
        }
       
        [TestMethod]
        public void Prospect_ShouldCreateProspect()
        {
            // Arrange
            var prospect = new Prospect();

            // Act

            // Assert
            Assert.IsNotNull(prospect);
        }
        
        [TestMethod]
        public void ToDto_ShouldReturnProspectDTO()
        {
            // Arrange
            var prospect = new Prospect();
            var activity = new Activity();
            prospect.Add(activity);

            // Act
            var dto = prospect.ToDto();

            // Assert
            Assert.IsInstanceOfType(dto, typeof(ProspectDTO));
        }
        
        //test Prospect constructor with dto as parameter containing an activity
        [TestMethod]
        public void Prospect_ShouldCreateProspectWithActivity()
        {
            // Arrange
            var activityDto = new ActivityDTO() 
            {
                _id = 1
            };
            var prospectDto = new ProspectDTO()
            {
                _activities = new List<ActivityDTO>() { activityDto }
            };
            
            

            // Act
            var prospect2 = new Prospect(prospectDto);

            // Assert
            Assert.AreEqual(prospectDto._activities[0]._id, prospect2.GetActivities().ToList()[0]._id);
        }
    }
}
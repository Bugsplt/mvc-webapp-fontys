using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class SightingTest
    {
       
        [TestMethod]
        public void SetCity()
        {
            //Arrange
            var sighting = new Sighting();
            var city = "Paris";

            //Act
            sighting.SetCity(city);

            //Assert
            Assert.AreEqual(city, sighting.City);
        }
        
        [TestMethod]
        public void SetStreet()
        {
            //Arrange
            var sighting = new Sighting();
            var street = "Rue de la Paix";

            //Act
            sighting.SetStreet(street);

            //Assert
            Assert.AreEqual(street, sighting.Street);
        }
        
        [TestMethod]
        public void SetLat()
        {
            //Arrange
            var sighting = new Sighting();
            var lat = (float) 48.85837;

            //Act
            sighting.SetLat(lat);

            //Assert
            Assert.AreEqual(lat, sighting.Lat);
        }
        
        [TestMethod]
        public void SetLng()
        {
            //Arrange
            var sighting = new Sighting();
            var lng = (float) 2.2945;

            //Act
            sighting.SetLng(lng);

            //Assert
            Assert.AreEqual(lng, sighting.Lng);
        }








    }
}
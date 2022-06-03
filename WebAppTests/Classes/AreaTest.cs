using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class AreaTest
    {
        // public void SetLat(float lat)
        [TestMethod]
        public void SetLat_Test()
        {
            //Arrange
            var area = new Area();
            //Act
            area.SetLat(10);
            //Assert
            Assert.AreEqual(10, area.Lat);
        }
        // public void SetLng(float lng)
        [TestMethod]
        public void SetLng_Test()
        {
            //Arrange
            var area = new Area();
            //Act
            area.SetLng(10);
            //Assert
            Assert.AreEqual(10, area.Lng);
        }
        // public void SetCity(string city)
        [TestMethod]
        public void SetCity_Test()
        {
            //Arrange
            var area = new Area();
            //Act
            area.SetCity("Test");
            //Assert
            Assert.AreEqual("Test", area.City);
        }
        // public void SetStreet(string street)
        [TestMethod]
        public void SetStreet_Test()
        {
            //Arrange
            var area = new Area();
            //Act
            area.SetStreet("Test");
            //Assert
            Assert.AreEqual("Test", area.Street);
        }
        // public void SetFbAdId(string fbAdId)
        [TestMethod]
        public void SetFbAdId_Test()
        {
            //Arrange
            var area = new Area();
            //Act
            area.SetFbAdId("Test");
            //Assert
            Assert.AreEqual("Test", area.FbAdId);
        }
        // public void SetIgAdId(string igAdId)
        [TestMethod]
        public void SetIgAdId_Test()
        {
            //Arrange
            var area = new Area();
            //Act
            area.SetIgAdId("Test");
            //Assert
            Assert.AreEqual("Test", area.IgAdId);
        }
        // public Area(){}
        [TestMethod]
        public void Area_Test()
        {
            //Arrange
            //Act
            var area = new Area();
            //Assert
            Assert.IsNotNull(area);
        }
        
        
        
    }
}
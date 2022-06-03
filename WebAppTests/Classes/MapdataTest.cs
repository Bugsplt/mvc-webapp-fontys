using System;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using LogicLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class MapdataTest
    {
        
        // public void SetCatStatus(CatStatus catStatus)
        [TestMethod]
        public void SetCatStatusTest()
        {
            //Arrange
            var mapData = new MapData();
            var catStatus = CatStatus.Deceased;
            //Act
            mapData.SetCatStatus(catStatus);
            //Assert
            Assert.AreEqual(mapData.CatStatus, catStatus);
        }
        // public void SetDate(DateTime date)
        [TestMethod]
        public void SetDateTest()
        {
            //Arrange
            var mapData = new MapData();
            var date = DateTime.Now;
            //Act
            mapData.SetDate(date);
            //Assert
            Assert.AreEqual(mapData.Date, date);
        }
        // public MapData(){}
        [TestMethod]
        public void MapDataTest()
        {
            //Arrange
            var mapData = new MapData();
            //Act
            //Assert
            Assert.IsNotNull(mapData);
        }
        // public MapDataDTO ToDto()
        [TestMethod]
        public void ToDtoTest()
        {
            //Arrange
            var mapData = new MapData();
            //Act
            var mapDataDto = mapData.ToDto();
            //Assert
            Assert.AreEqual(mapData.CatStatus.ToString(), mapDataDto.CatStatus.ToString());
            Assert.AreEqual(mapData.Date, mapDataDto.Date);
        }
    }
}
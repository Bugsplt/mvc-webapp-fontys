using System;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;
using LogicLayer.Classes;
using LogicLayer.Containers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDAL;
using WebAppProftS2Tests.Scrubs;
using WebAppProftS2Tests.Stubs;

namespace WebAppProftS2Tests.Containers
{
    [TestClass]
    public class MapDataContainerTests
    {
        [TestMethod]
        public void TestGetMapDataList()
        {
            // Arrange
            var manager = new ApiCallManagerMock();
            var container = new MapDataContainer(manager);
            container.Load();
            // Act
            var result = container.GetMapDataList();
            // Assert
            Assert.AreEqual(manager.MapDataDtos.Count, result.Count);
            Assert.AreEqual(manager.MapDataDtos[0].CatStatus.ToString(), result[0].CatStatus.ToString());
            Assert.AreEqual(manager.MapDataDtos[0].Date, result[0].Date);
            Assert.AreEqual(manager.MapDataDtos[0]._id, result[0]._id);
            Assert.AreEqual(manager.MapDataDtos[0]._searchNr, result[0]._searchNr);
        }

        [TestMethod]
        public void TestAdd()
        {
            // Arrange
            var manager = new ApiCallManagerMock();
            var container = new MapDataContainer(manager);
            container.Load();
            var mapData = new MapDataDTO(){CatStatus = CatStatus.Deceased, Date = DateTime.Now, _searchNr = "123456789"};
            var expectedCount = manager.MapDataDtos.Count + 1;
            // Act
            container.Add(new MapData(mapData));
            // Assert
            Assert.AreEqual(expectedCount, container.GetMapDataList().Count);
            Assert.AreEqual(mapData.CatStatus.ToString(), container.GetMapDataList()[^1].CatStatus.ToString());
            Assert.AreEqual(mapData.Date, container.GetMapDataList()[^1].Date);
            Assert.AreEqual(mapData._id, container.GetMapDataList()[^1]._id);
            Assert.AreEqual(mapData._searchNr, container.GetMapDataList()[^1]._searchNr);
        }
        
        [TestMethod]
        public void TestRemove()
        {
            // Arrange
            var manager = new ApiCallManagerMock();
            var container = new MapDataContainer(manager);
            container.Load();
            var mapData = new MapDataDTO() { CatStatus = CatStatus.Deceased, Date = DateTime.Now, _searchNr = "123456789" };
            var expectedCount = manager.MapDataDtos.Count - 1;
            // Act
            container.Remove(container.GetMapDataList()[0]);
            // Assert
            Assert.AreEqual(expectedCount, container.GetMapDataList().Count);
        }
        
        [TestMethod]
        public void TestClear()
        {
            // Arrange
            var manager = new ApiCallManagerMock();
            var container = new MapDataContainer(manager);
            container.Load();
            var expectedCount = 0;
            // Act
            container.Clear();
            // Assert
            Assert.AreEqual(expectedCount, container.GetMapDataList().Count);
        }

        [TestMethod]
        public void TestLoad()
        {
            // Arrange
            var manager = new ApiCallManagerMock();
            var container = new MapDataContainer(manager);
            var expectedCount = manager.MapDataDtos.Count;
            // Act
            container.Load();
            // Assert
            Assert.AreEqual(expectedCount, container.GetMapDataList().Count);
        }

        [TestMethod]
        public void TestMapDataContainer()
        {
            // Arrange
            var manager = new ApiCallManagerMock();
            // Act
            var container = new MapDataContainer(manager);
            // Assert
            Assert.IsNotNull(container);
        }
    }
}
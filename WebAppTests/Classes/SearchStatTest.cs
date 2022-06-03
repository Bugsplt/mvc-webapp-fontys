using System;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class SearchStatTest
    {
        [TestMethod]
        public void SetDateTest()
        {
            //Arrange
            var searchStat = new SearchStat();
            var date = new DateTime(2019, 1, 1);
            //Act
            searchStat.SetDate(date);
            //Assert
            Assert.AreEqual(date, searchStat.Date);
        }
        
        [TestMethod]
        public void SetImpressionsTest()
        {
            //Arrange
            var searchStat = new SearchStat();
            var impressions = 1;
            //Act
            searchStat.SetImpressions(impressions);
            //Assert
            Assert.AreEqual(impressions, searchStat.Impressions);
        }
        
        [TestMethod]
        public void SetInteractionsTest()
        {
            //Arrange
            var searchStat = new SearchStat();
            var interactions = 1;
            //Act
            searchStat.SetInteractions(interactions);
            //Assert
            Assert.AreEqual(interactions, searchStat.Interactions);
        }
        
        [TestMethod]
        public void SetLikesTest()
        {
            //Arrange
            var searchStat = new SearchStat();
            var likes = 1;
            //Act
            searchStat.SetLikes(likes);
            //Assert
            Assert.AreEqual(likes, searchStat.Likes);
        }
        
        [TestMethod]
        public void SearchStatConstructorTest()
        {
            //Arrange
            //Act
            var searchStat = new SearchStat();
            //Assert
            Assert.IsNotNull(searchStat);
        }
    }
}
using System;
using System.Linq;
using InterfaceLayer.DTO;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class CustomerTest
    {

        [TestMethod]
        public void TestAddSearch()
        {
            //arrange
            var customer = new Customer();
            var search = new Search();
            //act
            customer.AddSearch(search);
            //assert
            Assert.IsTrue(customer.GetSearches().Contains(search));
        }

        [TestMethod]
        public void TestRemoveSearch()
        {
            var customer = new Customer();
            var search1 = new Search();
            var search2 = new Search();
            var search3 = new Search();
            search1.SetFbPostId("1");
            search2.SetFbPostId("2");
            search3.SetFbPostId("3");
            customer.AddSearch(search1);
            customer.AddSearch(search2);
            customer.AddSearch(search3);
            //act
            customer.RemoveSearch(search2);
            //assert
            Assert.IsTrue(customer.GetSearches().Contains(search1) && customer.GetSearches().Contains(search3) &&
                          !customer.GetSearches().Contains(search2));
        }

        [TestMethod]
        public void TestAddActivity()
        {
            var customer = new Customer();
            var activity = new Activity();
            //act
            customer.AddActivity(activity);
            //assert
            Assert.IsTrue(customer.GetActivities().Contains(activity));
        }

        [TestMethod]
        public void TestRemoveActivity()
        {
            var customer = new Customer();
            var activity1 = new Activity();
            var activity2 = new Activity();
            var activity3 = new Activity();
            activity1.SetDate(new DateTime(2017, 1, 1));
            activity2.SetDate(new DateTime(2017, 1, 2));
            activity3.SetDate(new DateTime(2017, 1, 3));
            customer.AddActivity(activity1);
            customer.AddActivity(activity2);
            customer.AddActivity(activity3);
            //act
            customer.RemoveActivity(activity2);
            //assert
            Assert.IsTrue(customer.GetActivities().Contains(activity1) &&
                          customer.GetActivities().Contains(activity3) &&
                          !customer.GetActivities().Contains(activity2));
        }

        [TestMethod]
        public void TestClear()
        {
            var customer = new Customer();
            var activity1 = new Activity();
            var activity2 = new Activity();
            var activity3 = new Activity();
            activity1.SetDate(new DateTime(2017, 1, 1));
            activity2.SetDate(new DateTime(2017, 1, 2));
            activity3.SetDate(new DateTime(2017, 1, 3));
            customer.AddActivity(activity1);
            customer.AddActivity(activity2);
            customer.AddActivity(activity3);
            var search1 = new Search();
            var search2 = new Search();
            var search3 = new Search();
            search1.SetFbPostId("1");
            search2.SetFbPostId("2");
            search3.SetFbPostId("3");
            customer.AddSearch(search1);
            customer.AddSearch(search2);
            customer.AddSearch(search3);
            //act
            customer.Clear();
            //assert
            Assert.IsTrue(customer.GetSearches().Count == 0 && customer.GetActivities().Count == 0);
        }
        
        [TestMethod]
        public void TestSetLanguage()
        {
            //arrange
            var customer = new Customer();
            var language = "English";
            //act
            customer.SetLanguage(language);
            //assert
            Assert.AreEqual(language, customer.Language, "The language is not set correctly");
        }
        
        [TestMethod]
        public void TestToDto()
        {
            //arrange
            var customer = new Customer();
            var language = "English";
            var search = new Search
            {
                FbPostId = "1"
            };
            var activity = new Activity
            {
                Description = "test"
            };
            customer.AddActivity(activity);
            customer.AddSearch(search);
            customer.SetLanguage(language);
            //act
            var dto = customer.ToDto();
            //assert
            Assert.AreEqual(language, dto.Language, "The language is not set correctly");
            Assert.AreEqual(search.FbPostId, dto._searches[0].FbPostId, "The search is not set correctly");
            Assert.AreEqual(activity.Description, dto._activities[0].Description, "The activity is not set correctly");
        }

        [TestMethod]
        public void RemoveActivity()
        {
            var customer = new Customer();
            var activity1 = new Activity();
            activity1.SetDate(new DateTime(2017, 1, 1));
            var activity2 = new Activity();
            activity2.SetDate(new DateTime(2016, 1, 1));
            var activity3 = new Activity();
            activity3.SetDate(new DateTime(2016, 1, 2));
            customer.AddActivity(activity1);
            customer.AddActivity(activity2);
            customer.AddActivity(activity3);
            //act
            customer.RemoveActivity(activity2);
            //assert
            Assert.IsTrue(customer.GetActivities().Contains(activity1) &&
                          customer.GetActivities().Contains(activity3) &&
                          !customer.GetActivities().Contains(activity2));
        }
        
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveSearchNotFound()
        {
            //arrange
            var customer = new Customer();
            var search1 = new Search();
            var search2 = new Search();
            var search3 = new Search();
            search1.SetFbPostId("1");
            search2.SetFbPostId("2");
            search3.SetFbPostId("3");
            customer.AddSearch(search1);
            customer.AddSearch(search2);
            customer.AddSearch(search3);
            //act
            customer.RemoveSearch(new Search(new SearchDTO(){FbPostId = "4"}));
            //assert
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddDuplicateSearch()
        {
            //arrange
            var customer = new Customer();
            var search1 = new Search();
            var search2 = new Search();
            var search3 = new Search();
            search1.SetFbPostId("1");
            search2.SetFbPostId("2");
            search3.SetFbPostId("3");
            customer.AddSearch(search1);
            customer.AddSearch(search2);
            customer.AddSearch(search3);
            //act
            customer.AddSearch(search2);
            //assert
            
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddActivityDuplicate()
        {
            //arrange
            var customer = new Customer();
            var activity1 = new Activity();
            var activity2 = new Activity();
            var activity3 = new Activity();
            activity1.SetDate(new DateTime(2017, 1, 1));
            activity2.SetDate(new DateTime(2016, 1, 1));
            activity3.SetDate(new DateTime(2016, 1, 2));
            customer.AddActivity(activity1);
            customer.AddActivity(activity2);
            customer.AddActivity(activity3);
            //act
            customer.AddActivity(activity2);
            //assert
        }
    }
}
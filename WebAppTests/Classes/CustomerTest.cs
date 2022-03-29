using System.Linq;
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
            customer.AddSearch(search1);
            customer.AddSearch(search2);
            customer.AddSearch(search3);
            //act
            customer.RemoveSearch(search2);
            //assert
            Assert.IsTrue(customer.GetSearches().Contains(search1) && customer.GetSearches().Contains(search3) && !customer.GetSearches().Contains(search2));
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
            customer.AddActivity(activity1);
            customer.AddActivity(activity2);
            customer.AddActivity(activity3);
            //act
            customer.RemoveActivity(activity2);
            //assert
            Assert.IsTrue(customer.GetActivities().Contains(activity1) && customer.GetActivities().Contains(activity3) && !customer.GetActivities().Contains(activity2));
        }
        
        [TestMethod]
        public void TestClear()
        {
            var customer = new Customer();
            customer.AddActivity(new Activity());
            customer.AddActivity(new Activity());
            customer.AddActivity(new Activity());
            customer.AddSearch(new Search());
            customer.AddSearch(new Search());
            customer.AddSearch(new Search());
            //act
            customer.Clear();
            //assert
            Assert.IsTrue(customer.GetSearches().Count == 0 && customer.GetActivities().Count == 0);
        }
    }
}
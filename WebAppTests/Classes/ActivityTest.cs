using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class ActivityTest
    {
        [TestMethod]
        public void TestSetType()
        {
            //Arrange
            Activity activity = new Activity();
            //Act
            activity.SetType("test");
            //Assert
            Assert.AreEqual("test", activity.Type);
        }
        
        [TestMethod]
        public void TestSetDescription()
        {
            //Arrange
            Activity activity = new Activity();
            //Act
            activity.SetDescription("test");
            //Assert
            Assert.AreEqual("test", activity.Description);
        }
        
        
    }
}
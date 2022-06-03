using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            //Arrange
            //Act
            var factory = new Factory();
            //Assert
            Assert.IsNotNull(factory);
        }
        
    }
}
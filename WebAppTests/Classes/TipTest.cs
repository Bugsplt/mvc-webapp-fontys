using System;
using LogicLayer.Classes;
using LogicLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class TipTest
    {
        [TestMethod]
        public void TestSetSighting()
        {
            //arrange
            var tip = new Tip();
            var sighting = new Sighting();
            //act
            tip.SetSighting(sighting);
            //assert
            Assert.AreEqual(sighting, tip.Sighting);
        }
        
        [TestMethod]
        public void TestSetPlatform()
        {
            //arrange
            var tip = new Tip();
            var platform = new Platform();
            //act
            tip.SetPlatform(platform);
            //assert
            Assert.AreEqual(platform, tip.Platform);
        }
        
        [TestMethod]
        public void TestSetSightingDate()
        {
            //arrange
            var tip = new Tip();
            var date = new DateTime(2019, 1, 1);
            //act
            tip.SetSightingDate(date);
            //assert
            Assert.AreEqual(date, tip.SightingDate);
        }
       
        [TestMethod]
        public void TestSetDate()
        {
            //arrange
            var tip = new Tip();
            var date = new DateTime(2019, 1, 1);
            //act
            tip.SetDate(date);
            //assert
            Assert.AreEqual(date, tip.Date);
        }
       
        [TestMethod]
        public void TestSetContact()
        {
            //arrange
            var tip = new Tip();
            var contact = "contact";
            //act
            tip.SetContact(contact);
            //assert
            Assert.AreEqual(contact, tip.Contact);
        }
        
        [TestMethod]
        public void TestSetContent()
        {
            //arrange
            var tip = new Tip();
            var content = "content";
            //act
            tip.SetContent(content);
            //assert
            Assert.AreEqual(content, tip.Content);
        }
        
        [TestMethod]
        public void TestTip()
        {
            //arrange
            //act
            var tip = new Tip();
            //assert
            Assert.IsNotNull(tip);
        }
    }
}
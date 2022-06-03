using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void TestSearchConstructorDTO()
        {
            //Arrange
            var searchStats = new List<SearchStatDTO>();
            searchStats.Add(new SearchStatDTO()
            {
                Date = new DateTime(2017, 1, 1),
                Impressions = 1,
                Interactions = 2,
                Likes = 3,
                _id = 4,
                _searchNr = "5"
            });
            var searchDto = new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = searchStats
            };
            //Act
            var search = new Search(searchDto);
            //Assert
            Assert.AreEqual(searchDto.CatStatus.ToString(), search.CatStatus.ToString());
            Assert.AreEqual(searchDto.AdStatus.ToString(), search.AdStatus.ToString());
            Assert.AreEqual(searchDto.CatName, search.CatName);
            Assert.AreEqual(searchDto.PostMssg, search.PostMssg);
            Assert.AreEqual(searchDto.AdCampId, search.AdCampId);
            Assert.AreEqual(searchDto.Tag, search.Tag);
            Assert.AreEqual(searchDto.FbPostId, search.FbPostId);
            Assert.AreEqual(searchDto.IgPostId, search.IgPostId);
            Assert.AreEqual(searchDto.IgPostUrl, search.IgPostUrl);
            Assert.AreEqual(searchDto.CatImg, search.CatImg);
            Assert.AreEqual(searchDto.MockupImg, search.MockupImg);
            Assert.AreEqual(searchDto.PostImg, search.PostImg);
            Assert.AreEqual(searchDto.AdSpent, search.AdSpent);
            Assert.AreEqual(searchDto._searchNr, search._searchNr);
        }

        [TestMethod]
        public void TestToDto()
        {
            //Arrange
            var searchStats = new List<SearchStatDTO>();
            searchStats.Add(new SearchStatDTO()
            {
                Date = new DateTime(2017, 1, 1),
                Impressions = 1,
                Interactions = 2,
                Likes = 3,
                _id = 4,
                _searchNr = "5"
            });
            var feedback = new FeedbackDTO()
            {
                FeedbackDate = new DateTime(2017, 1, 1),
                RatingDate = new DateTime(2017, 1, 2),
                Content = "TestContent",
                Score = 3,
                _feedbackId = 3,
                _ratingId = 11
            };
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = searchStats,
                Feedback = feedback
            });
            //Act
            var searchDto = search.ToDto();
            //Assert
            Assert.AreEqual(search.CatStatus.ToString(), searchDto.CatStatus.ToString());
            Assert.AreEqual(search.AdStatus.ToString(), searchDto.AdStatus.ToString());
            Assert.AreEqual(search.CatName, searchDto.CatName);
            Assert.AreEqual(search.PostMssg, searchDto.PostMssg);
            Assert.AreEqual(search.AdCampId, searchDto.AdCampId);
            Assert.AreEqual(search.Tag, searchDto.Tag);
            Assert.AreEqual(search.FbPostId, searchDto.FbPostId);
            Assert.AreEqual(search.IgPostId, searchDto.IgPostId);
            Assert.AreEqual(search.IgPostUrl, searchDto.IgPostUrl);
            Assert.AreEqual(search.CatImg, searchDto.CatImg);
            Assert.AreEqual(search.MockupImg, searchDto.MockupImg);
            Assert.AreEqual(search.PostImg, searchDto.PostImg);
        }

        [TestMethod]
        public void TestGetTips()
        {
            //Arrange
            var tips = new List<TipDTO>();
            tips.Add(new TipDTO()
            {
                Sighting = new SightingDTO(),
                Platform = Platform.Fb,
                SightingDate = new DateTime(2017, 1, 1),
                Date = new DateTime(2017, 1, 1),
                Contact = "TestContact",
                Content = "TestContent",
                _id = 1
            });
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _tips = tips
            });
            //Act
            var returnedTips = search.GetTips();
            //Assert
            Assert.AreEqual(1, returnedTips.Count);
            Assert.AreEqual(tips[0]._id, returnedTips[0].ToDto()._id);
            Assert.AreEqual(tips[0].Platform, returnedTips[0].ToDto().Platform);
            Assert.AreEqual(tips[0].SightingDate, returnedTips[0].ToDto().SightingDate);
            Assert.AreEqual(tips[0].Date, returnedTips[0].ToDto().Date);
            Assert.AreEqual(tips[0].Contact, returnedTips[0].ToDto().Contact);
            Assert.AreEqual(tips[0].Content, returnedTips[0].ToDto().Content);
        }

        [TestMethod]
        public void TestGetAreas()
        {
            //Arrange
            var areas = new List<AreaDTO>();
            areas.Add(new AreaDTO()
            {
                Lat = 3,
                Lng = 4,
                City = "TestCity",
                Street = "TestStreet",
                _id = 1
            });
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = areas
            });
            //Act
            var returnedAreas = search.GetAreas();
            //Assert
            Assert.AreEqual(1, returnedAreas.Count);
            Assert.AreEqual(areas[0]._id, returnedAreas[0].ToDto()._id);
            Assert.AreEqual(areas[0].Lat, returnedAreas[0].ToDto().Lat);
            Assert.AreEqual(areas[0].Lng, returnedAreas[0].ToDto().Lng);
            Assert.AreEqual(areas[0].City, returnedAreas[0].ToDto().City);
            Assert.AreEqual(areas[0].Street, returnedAreas[0].ToDto().Street);
        }

        [TestMethod]
        public void TestGetSearchStats()
        {
            //Arrange
            var searchStats = new List<SearchStatDTO>();
            searchStats.Add(new SearchStatDTO()
            {
                _id = 1,
                _searchNr = "123",
                Date = new DateTime(2019, 1, 1),
                Impressions = 3,
                Interactions = 2,
                Likes = 4
            });
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = searchStats
            });
            //Act
            var returnedSearchStats = search.GetSearchStats();
            //Assert
            Assert.AreEqual(1, returnedSearchStats.Count);
            Assert.AreEqual(searchStats[0]._id, returnedSearchStats[0].ToDto()._id);
            Assert.AreEqual(searchStats[0]._searchNr, returnedSearchStats[0].ToDto()._searchNr);
            Assert.AreEqual(searchStats[0].Date, returnedSearchStats[0].ToDto().Date);
            Assert.AreEqual(searchStats[0].Impressions, returnedSearchStats[0].ToDto().Impressions);
            Assert.AreEqual(searchStats[0].Interactions, returnedSearchStats[0].ToDto().Interactions);
            Assert.AreEqual(searchStats[0].Likes, returnedSearchStats[0].ToDto().Likes);
        }

        // public void TestSetCatName
        [TestMethod]
        public void TestSetCatName()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetCatName("TestCatName2");
            //Assert
            Assert.AreEqual("TestCatName2", search.ToDto().CatName);
        }
        
         // public void TestSetPostMssg
        [TestMethod]
        public void TestSetPostMssg()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetPostMssg("TestPostMssg2");
            //Assert
            Assert.AreEqual("TestPostMssg2", search.ToDto().PostMssg);
        }
        
       
        [TestMethod]
        public void TestSetAdCampId()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetAdCampId("TestAdCampId2");
            //Assert
            Assert.AreEqual("TestAdCampId2", search.ToDto().AdCampId);
        }
        
        [TestMethod]
        public void TestSetTag()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetTag("TestTag2");
            //Assert
            Assert.AreEqual("TestTag2", search.ToDto().Tag);
        }
       
        [TestMethod]
        public void TestSetFbPostId()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetFbPostId("TestFbPostId2");
            //Assert
            Assert.AreEqual("TestFbPostId2", search.ToDto().FbPostId);
        }
   
        [TestMethod]
        public void TestSetIgPostId()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetIgPostId("TestIgPostId2");
            //Assert
            Assert.AreEqual("TestIgPostId2", search.ToDto().IgPostId);
        }
      
        [TestMethod]
        public void TestSetIgPostUrl()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetIgPostUrl("TestIgPostUrl2");
            //Assert
            Assert.AreEqual("TestIgPostUrl2", search.ToDto().IgPostUrl);
        }
      
        [TestMethod]
        public void TestSetCatImg()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetCatImg("TestCatImg2");
            //Assert
            Assert.AreEqual("TestCatImg2", search.ToDto().CatImg);
        }
        
        [TestMethod]
        public void TestSetMockupImg()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetMockupImg("TestMockupImg2");
            //Assert
            Assert.AreEqual("TestMockupImg2", search.ToDto().MockupImg);
        }
    
        [TestMethod]
        public void TestSetPostImg()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetPostImg("TestPostImg2");
            //Assert
            Assert.AreEqual("TestPostImg2", search.ToDto().PostImg);
        }
        
        [TestMethod]
        public void TestSetAdSpent()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetAdSpent(1);
            //Assert
            Assert.AreEqual(1, search.ToDto().AdSpent);
        }
        
        [TestMethod]
        public void TestSetFeedback()
        {
            //Arrange
            var feedback = new FeedbackDTO() {_feedbackId = 1};
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            //Act
            search.SetFeedback(new Feedback(feedback));
            //Assert
            Assert.AreEqual(feedback._feedbackId, search.ToDto().Feedback._feedbackId);
        }
        
        [TestMethod]
        public void TestAddArea()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var area = new AreaDTO() {_id = 1};
            //Act
            search.Add(new Area(area));
            //Assert
            Assert.AreEqual(1, search.ToDto()._areas.Count);
            Assert.AreEqual(area._id, search.ToDto()._areas[0]._id);
        }
        
        [TestMethod]
        public void TestRemoveArea()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var area = new AreaDTO() {_id = 1};
            search.Add(new Area(area));
            //Act
            search.Remove(new Area(area));
            //Assert
            Assert.AreEqual(0, search.ToDto()._areas.Count);
        }
        
        [TestMethod]
        public void TestAddTip()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var tip = new TipDTO() {_id = 1};
            //Act
            search.Add(new Tip(tip));
            //Assert
            Assert.AreEqual(1, search.ToDto()._tips.Count);
            Assert.AreEqual(tip._id, search.ToDto()._tips[0]._id);
        }
        
        [TestMethod]
        public void TestRemoveTip()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var tip = new TipDTO() {_id = 1};
            search.Add(new Tip(tip));
            //Act
            search.Remove(new Tip(tip));
            //Assert
            Assert.AreEqual(0, search.ToDto()._tips.Count);
        }
        
        [TestMethod]
        public void TestAddSearchStat()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var searchStat = new SearchStatDTO() {_id = 1};
            //Act
            search.Add(new SearchStat(searchStat));
            //Assert
            Assert.AreEqual(1, search.ToDto()._searchStats.Count);
            Assert.AreEqual(searchStat._id, search.ToDto()._searchStats[0]._id);
        }
        
        [TestMethod]
        public void TestRemoveSearchStat()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var searchStat = new SearchStatDTO() {_id = 1};
            search.Add(new SearchStat(searchStat));
            //Act
            search.Remove(new SearchStat(searchStat));
            //Assert
            Assert.AreEqual(0, search.ToDto()._searchStats.Count);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLoad()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var searchStat = new SearchStatDTO() {_id = 1};
            search.Add(new SearchStat(searchStat));
            //Act
            search.Load();
            //Assert
            Assert.AreEqual(1, search.ToDto()._searchStats.Count);
            Assert.AreEqual(searchStat._id, search.ToDto()._searchStats[0]._id);
        }
        
        [TestMethod]
        public void TestClear()
        {
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var searchStat = new SearchStatDTO() {_id = 1};
            search.Add(new SearchStat(searchStat));
            //Act
            search.Clear();
            //Assert
            Assert.AreEqual(0, search.ToDto()._searchStats.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRemoveNonContainedSearchStat(){
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var searchStat = new SearchStatDTO() {_id = 1};
            search.Add(new SearchStat(searchStat));
            var searchStat2 = new SearchStatDTO() {_id = 2};
            //Act
            search.Remove(new SearchStat(searchStat2));
            //Assert
            Assert.AreEqual(1, search.ToDto()._searchStats.Count);
            Assert.AreEqual(searchStat._id, search.ToDto()._searchStats[0]._id);
        }
        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRemoveNonContainedArea(){
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var area = new AreaDTO() {_id = 1};
            var area2 = new AreaDTO() {_id = 2};
            search.Add(new Area(area2));
            var expectedAmount = search.GetAreas().Count;
            //Act
            search.Remove(new Area(area));
            //Assert
            Assert.AreEqual(expectedAmount , search.GetAreas().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestRemoveNonContainedTip(){
            //Arrange
            var search = new Search(new SearchDTO()
            {
                CatStatus = CatStatus.Deceased,
                AdStatus = AdStatus.Active,
                CatName = "TestCatName",
                PostMssg = "TestPostMssg",
                AdCampId = "TestAdCampId",
                Tag = "TestTag",
                FbPostId = "TestFbPostId",
                IgPostId = "TestIgPostId",
                IgPostUrl = "TestIgPostUrl",
                CatImg = "TestCatImg",
                MockupImg = "TestMockupImg",
                PostImg = "TestPostImg",
                AdSpent = 0,
                _searchNr = "TestSearchNr",
                _searchStats = new List<SearchStatDTO>(),
                _areas = new List<AreaDTO>()
            });
            var tip = new TipDTO() {_id = 1};
            var tip2 = new TipDTO() {_id = 2};
            search.Add(new Tip(tip));
            var expectedAmount = search.GetTips().Count;
            //Act
            search.Remove(new Tip(tip2));
            //Assert
            Assert.AreEqual(expectedAmount, search.ToDto()._searchStats.Count);
        }

    }
}
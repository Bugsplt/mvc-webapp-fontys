using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;

namespace WebAppProftS2Tests.Stubs
{
    public class SearchStub
    {
        public List<SearchDTO> Searches;

        public SearchStub()
        {
            AreaStub areaStub = new();
            SearchStatStub searchStatStub = new();
            FeedbackStub feedbackStub = new();
            TipStub tipStub = new();

            Searches = new()
            {
                new SearchDTO()
                {
                    _areas = new List<AreaDTO> {areaStub.Areas[0]},
                    _searchNr = "1",
                    _searchStats = new List<SearchStatDTO> {searchStatStub.SearchStats[0]},
                    _tips = new List<TipDTO> {tipStub.Tips[0]},
                    AdCampId = "1",
                    AdSpent = 1.01,
                    AdStatus = AdStatus.Active,
                    CatImg = "CatImg1",
                    CatName = "CatName1",
                    CatStatus = CatStatus.Deceased,
                    PostImg = "PostImg1",
                    PostMssg = "PostMssg1",
                    FbPostId = "1",
                    IgPostId = "1",
                    IgPostUrl = "IgPostUrl1",
                    MockupImg = "MockupImg1",
                    Feedback = feedbackStub.Feedbacks[0],
                    Tag = "Tag1",
                },
                new SearchDTO()
                {
                    _areas = new List<AreaDTO> {areaStub.Areas[1]},
                    _searchNr = "2",
                    _searchStats = new List<SearchStatDTO> {searchStatStub.SearchStats[1]},
                    _tips = new List<TipDTO> {tipStub.Tips[1]},
                    AdCampId = "2",
                    AdSpent = 2.01,
                    AdStatus = AdStatus.Review,
                    CatImg = "CatImg2",
                    CatName = "CatName2",
                    CatStatus = CatStatus.Missing,
                    PostImg = "PostImg2",
                    PostMssg = "PostMssg2",
                    FbPostId = "2",
                    IgPostId = "2",
                    IgPostUrl = "IgPostUrl2",
                    MockupImg = "MockupImg2",
                    Feedback = feedbackStub.Feedbacks[1],
                    Tag = "Tag2",
                },
                new SearchDTO()
                {
                    _areas = new List<AreaDTO> {areaStub.Areas[2]},
                    _searchNr = "3",
                    _searchStats = new List<SearchStatDTO> {searchStatStub.SearchStats[2]},
                    _tips = new List<TipDTO> {tipStub.Tips[2]},
                    AdCampId = "3",
                    AdSpent = 3.01,
                    AdStatus = AdStatus.Stopped,
                    CatImg = "CatImg3",
                    CatName = "CatName3",
                    CatStatus = CatStatus.Safe,
                    PostImg = "PostImg3",
                    PostMssg = "PostMssg3",
                    FbPostId = "3",
                    IgPostId = "3",
                    IgPostUrl = "IgPostUrl3",
                    MockupImg = "MockupImg3",
                    Feedback = feedbackStub.Feedbacks[2],
                    Tag = "Tag3",
                }
            };
        }
    }
}
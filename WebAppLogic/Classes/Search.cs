using System.Collections.Generic;
using InterfaceLayer.DTO;
using LogicLayer.Enums;

namespace LogicLayer.Classes
{
    public class Search
    {
        public Feedback Feedback { get; private set; }
        public CatStatus CatStatus { get; private set; }
        public AdStatus AdStatus { get; private set; }
        public string CatName { get; private set; }
        public string PostMssg { get; private set; }
        public string AdCampId { get; private set; }
        public string Tag { get; private set; }
        public string FbPostId { get; private set; }
        public string IgPostId { get; private set; }
        public string IgPostUrl { get; private set; }
        public string CatImg { get; private set; }
        public string MockupImg { get; private set; }
        public string PostImg { get; private set; }
        public double AdSpent { get; private set; }

        private string _searchNr;
        private List<Tip> _tips;
        private List<Area> _areas;
        private List<SearchStat> _searchStats;


        public IReadOnlyList<Tip> GetTips()
        {
            return _tips;
        }

        public IReadOnlyList<Area> GetAreas()
        {
            return _areas;
        }

        public IReadOnlyList<SearchStat> GetSearchStats()
        {
            return _searchStats;
        }

        public void SetCatName(string catName)
        {
            CatName = catName;
        }

        public void SetPostMssg(string postMssg)
        {
            PostMssg = postMssg;
        }

        public void SetAdCampId(string adCampId)
        {
            AdCampId = adCampId;
        }

        public void SetTag(string tag)
        {
            Tag = tag;
        }

        public void SetFbPostId(string fbPostId)
        {
            FbPostId = fbPostId;
        }

        public void SetIgPostId(string igPostId)
        {
            IgPostId = igPostId;
        }

        public void SetIgPostUrl(string igPostUrl)
        {
            IgPostUrl = igPostUrl;
        }

        public void SetCatImg(string catImg)
        {
            CatImg = catImg;
        }

        public void SetMockupImg(string mockupImg)
        {
            MockupImg = mockupImg;
        }

        public void SetPostImg(string postImg)
        {
            PostImg = postImg;
        }

        public void SetAdSpent(double adSpent)
        {
            AdSpent = adSpent;
        }

        public void SetFeedback(Feedback feedback)
        {
            Feedback = feedback;
        }

        public void Add(Area area)
        {
            _areas.Add(area);
        }

        public void Remove(Area area)
        {
            _areas.Remove(area);
        }

        public void Add(Tip tip)
        {
            _tips.Add(tip);
        }

        public void Remove(Tip tip)
        {
            _tips.Remove(tip);
        }

        public void Add(SearchStat searchStat)
        {
            _searchStats.Add(searchStat);
        }

        public void Remove(SearchStat searchStat)
        {
            _searchStats.Remove(searchStat);
        }

        public void Load()
        {
            //todo get this searches content from api and fill out lists
        }

        public void Clear()
        {
            _tips.Clear();
            _areas.Clear();
            _searchStats.Clear();
        }
        
        public Search(){}

        public Search(SearchDTO dto)
        {
            var tips = new List<Tip>();
            if (dto._tips != null)
            {
                foreach (var tip in dto._tips)
                {
                    tips.Add(new Tip(tip));
                }
            }

            var areas = new List<Area>();
            if (dto._areas != null)
            {
                foreach (var area in dto._areas)
                {
                    areas.Add(new Area(area));
                }
            }

            var searchStats = new List<SearchStat>();
            if (dto._searchStats != null)
            {
                foreach (var searchStat in dto._searchStats)
                {
                    searchStats.Add(new SearchStat(searchStat));
                }
            }

            if (dto.Feedback != null)
            {
                Feedback = new Feedback(dto.Feedback);
            }

            CatStatus = (CatStatus) dto.CatStatus;
            AdStatus = (AdStatus) dto.AdStatus;
            CatName = dto.CatName;
            PostMssg = dto.PostMssg;
            AdCampId = dto.AdCampId;
            Tag = dto.Tag;
            FbPostId = dto.FbPostId;
            IgPostId = dto.IgPostId;
            IgPostUrl = dto.IgPostUrl;
            CatImg = dto.CatImg;
            MockupImg = dto.MockupImg;
            PostImg = dto.PostImg;
            AdSpent = dto.AdSpent;
            _searchNr = dto._searchNr;
            _tips = tips;
            _areas = areas;
            _searchStats = searchStats;
        }

        public SearchDTO ToDto()
        {
            var tipDtos = new List<TipDTO>();
            foreach (var tip in _tips)
            {
                tipDtos.Add(tip.ToDto());
            }

            var areaDtos = new List<AreaDTO>();
            foreach (var area in _areas)
            {
                areaDtos.Add(area.ToDto());
            }

            var searchStatDtos = new List<SearchStatDTO>();
            foreach (var searchStat in _searchStats)
            {
                searchStatDtos.Add(searchStat.ToDto());
            }

            return new SearchDTO()
            {
                Feedback = Feedback.ToDto(),
                CatStatus = (InterfaceLayer.Enums.CatStatus) CatStatus,
                AdStatus = (InterfaceLayer.Enums.AdStatus) AdStatus,
                CatName = CatName,
                PostMssg = PostMssg,
                AdCampId = AdCampId,
                Tag = Tag,
                FbPostId = FbPostId,
                IgPostId = IgPostId,
                IgPostUrl = IgPostUrl,
                CatImg = CatImg,
                MockupImg = MockupImg,
                PostImg = PostImg,
                AdSpent = AdSpent,
                _searchNr = _searchNr,
                _tips = tipDtos,
                _areas = areaDtos,
                _searchStats = searchStatDtos,
            };
        }
    }
}
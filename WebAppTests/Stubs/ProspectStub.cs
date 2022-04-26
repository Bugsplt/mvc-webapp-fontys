using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class ProspectStub
    {
        public List<ProspectDTO> Prospects;

        public ProspectStub()
        {
            ActivityStub activityStub = new();
            
            Prospects = new List<ProspectDTO>
            {
                new()
                {
                    CatImg = "CatImg1",
                    CatName = "Catname1",
                    _activities = new List<ActivityDTO>{activityStub.Activities[0]},
                    Email = "Email1",
                    City = "City1",
                    Country = "Country1",
                    Language = "Language1",
                    Lat = (float) 55.041,
                    Lng = (float) 5.891,
                    MockupImg = "MockupImg1",
                    PostMssg = "PostMssg1",
                    ProspectNr = "1",
                    PhoneNr = "1"
                },
                new()
                {
                    CatImg = "CatImg2",
                    CatName = "Catname2",
                    _activities = new List<ActivityDTO>{activityStub.Activities[1]},
                    Email = "Email2",
                    City = "City2",
                    Country = "Country2",
                    Language = "Language2",
                    Lat = (float) 56.041,
                    Lng = (float) 6.891,
                    MockupImg = "MockupImg2",
                    PostMssg = "PostMssg2",
                    ProspectNr = "2",
                    PhoneNr = "2"
                },
                new()
                {
                    CatImg = "CatImg3",
                    CatName = "Catname3",
                    _activities = new List<ActivityDTO>{activityStub.Activities[2]},
                    Email = "Email3",
                    City = "City3",
                    Country = "Country3",
                    Language = "Language3",
                    Lat = (float) 57.041,
                    Lng = (float) 7.891,
                    MockupImg = "MockupImg3",
                    PostMssg = "PostMssg3",
                    ProspectNr = "3",
                    PhoneNr = "3"
                }
            };
        }
    }
}
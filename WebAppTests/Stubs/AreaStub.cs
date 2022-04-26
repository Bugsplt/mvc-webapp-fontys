using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class AreaStub
    {
        public List<AreaDTO> Areas;

        public AreaStub()
        {
            Areas = new List<AreaDTO>
            {
                new()
                {
                    _id = 1,
                    City = "City1",
                    FbAdId = "1",
                    IgAdId = "1",
                    Lat = (float) 55.041,
                    Lng = (float) 5.891,
                    Street = "Street1"
                },
                new()
                {
                    _id = 2,
                    City = "City2",
                    FbAdId = "2",
                    IgAdId = "2",
                    Lat = (float) 56.041,
                    Lng = (float) 6.891,
                    Street = "Street2"
                },
                new()
                {
                    _id = 3,
                    City = "City3",
                    FbAdId = "3",
                    IgAdId = "3",
                    Lat = (float) 58.041,
                    Lng = (float) 8.891,
                    Street = "Street3"
                }
            };
        }
    }
}
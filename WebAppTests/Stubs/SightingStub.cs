using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class SightingStub
    {
        public List<SightingDTO> Sightings;

        public SightingStub()
        {
            Sightings = new()
            {
                new SightingDTO()
                {
                    _id = 1,
                    City = "City1", 
                    Street = "Street1",
                    Lat = (float) 52.345,
                    Lng = (float) 5.345
                },
                new SightingDTO()
                {
                    _id = 2,
                    City = "City2", 
                    Street = "Street2",
                    Lat = (float) 53.345,
                    Lng = (float) 6.345
                },
                new SightingDTO()
                {
                    _id = 3,
                    City = "City3", 
                    Street = "Street3",
                    Lat = (float) 54.345,
                    Lng = (float) 7.345
                }
            };
        }
    }
}
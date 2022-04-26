using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class SightingStub
    {
        public List<SightingDTO> Sightings;

        public SightingStub()
        {
            Sightings.Add(new SightingDTO()
            {
                _id = 1,
                City = "Nijmegen", 
                Street = "Mahoniastraat",
                Lat = (float) 52.345,
                Lng = (float) 5.345
            });
        }
    }
}
using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;
using InterfaceLayer.Enums;

namespace WebAppProftS2Tests.Stubs
{
    public class TipStub
    {
        public List<TipDTO> Tips;

        public TipStub()
        {
            SightingStub sightingStub = new();
            Tips = new List<TipDTO>
            {
                new()
                {
                    _id = 1,
                    Contact = "Contact1",
                    Content = "Content1",
                    Date = new DateTime(2022, 4, 26),
                    Platform = Platform.Fb,
                    Sighting = sightingStub.Sightings[0],
                    SightingDate = new DateTime(2022, 4, 26)
                },
                new()
                {
                    _id = 2,
                    Contact = "Contact2",
                    Content = "Content2",
                    Date = new DateTime(2022, 4, 27),
                    Platform = Platform.Ig,
                    Sighting = sightingStub.Sightings[1],
                    SightingDate = new DateTime(2022, 4, 27)
                },
                new()
                {
                    _id = 3,
                    Contact = "Contact3",
                    Content = "Content3",
                    Date = new DateTime(2022, 4, 28),
                    Platform = Platform.Kr,
                    Sighting = sightingStub.Sightings[2],
                    SightingDate = new DateTime(2022, 4, 28)
                }
            };
        }
    }
}
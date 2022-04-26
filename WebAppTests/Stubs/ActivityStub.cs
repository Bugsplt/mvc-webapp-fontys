using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class ActivityStub
    {
        public List<ActivityDTO> Activities;

        public ActivityStub()
        {
            Activities = new List<ActivityDTO>
            {
                new()
                {
                    Date = new DateTime(2022, 4, 26),
                    _id = 1,
                    Description = "Description1",
                    Type = "Type1"
                },
                new()
                {
                    Date = new DateTime(2022, 4, 27),
                    _id = 2,
                    Description = "Description2",
                    Type = "Type2"
                },
                new()
                {
                    Date = new DateTime(2022, 4, 28),
                    _id = 3,
                    Description = "Description3",
                    Type = "Type3"
                }
            };
        }
    }
}
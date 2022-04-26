using System;
using System.Collections.Generic;
using InterfaceLayer.DTO;

namespace WebAppProftS2Tests.Stubs
{
    public class FeedbackStub
    {
        public List<FeedbackDTO> Feedbacks;

        public FeedbackStub()
        {
            Feedbacks = new List<FeedbackDTO>
            {
                new()
                {
                    FeedbackDate = new DateTime(2022,4,26),
                    _feedbackId = 1,
                    _ratingId = 1,
                    Content = "Content1",
                    RatingDate = new DateTime(2022,4,26),
                    Score = 1
                },
                new()
                {
                    FeedbackDate = new DateTime(2022,4,27),
                    _feedbackId = 2,
                    _ratingId = 2,
                    Content = "Content2",
                    RatingDate = new DateTime(2022,4,27),
                    Score = 2
                },
                new()
                {
                    FeedbackDate = new DateTime(2022,4,28),
                    _feedbackId = 3,
                    _ratingId = 3,
                    Content = "Content3",
                    RatingDate = new DateTime(2022,4,28),
                    Score = 3
                }
            };
        }
    }
}
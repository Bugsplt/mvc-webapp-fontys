using System;

namespace InterfaceLayer.DTO
{
    public class FeedbackDTO
    {
        public DateTime FeedbackDate { get; set; }
        public DateTime RatingDate { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
        public int _feedbackId { get; set; }
        public int _ratingId { get; set; }
    }
}
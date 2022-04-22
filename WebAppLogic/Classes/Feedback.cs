using System;
using InterfaceLayer.DTO;

namespace LogicLayer.Classes
{
    public class Feedback
    {
        public DateTime FeedbackDate { get; private set; }
        public DateTime RatingDate { get; private set; }
        public string Content { get; private set; }
        public int Score { get; private set; }
        
        private int _feedbackId;
        private int _ratingId;
        
        public void SetFeedbackDate(DateTime date)
        {
            FeedbackDate = date;
        } 
        
        public void SetRatingDate(DateTime date)
        {
            RatingDate = date;
        }
        
        public void SetContent(string content)
        {
            Content = content;
        }
        
        public void SetScore(int score)
        {
            Score = score;
        }

        public Feedback(){}

        public Feedback(FeedbackDTO dto)
        {
            FeedbackDate = dto.FeedbackDate;
            RatingDate = dto.RatingDate;
            Content = dto.Content;
            Score = dto.Score;
            _feedbackId = dto._feedbackId;
            _ratingId = dto._ratingId;
        }
        
        public FeedbackDTO ToDto()
        {
            return new()
            {
                FeedbackDate = FeedbackDate,
                RatingDate = RatingDate,
                Content = Content,
                Score = Score,
                _feedbackId = _feedbackId,
                _ratingId = _ratingId
            };
        }
    }
}
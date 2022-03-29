using System;

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
    }
}
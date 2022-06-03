using System;
using LogicLayer.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAppProftS2Tests.Classes
{
    [TestClass]
    public class FeedbackTest
    {
        // public void SetFeedbackDate(DateTime date)
        [TestMethod]
        public void SetFeedbackDate_DateIsNull_ReturnFalse()
        {
            // Arrange
            var feedback = new Feedback();
            var date = new DateTime(2019, 1, 1);

            // Act
            feedback.SetFeedbackDate(date);

            // Assert
            Assert.AreEqual(date, feedback.FeedbackDate);
        }
        // public void SetRatingDate(DateTime date)
        [TestMethod]
        public void SetRatingDate_DateIsNull_ReturnFalse()
        {
            // Arrange
            var feedback = new Feedback();
            var date = new DateTime(2019, 10, 10);

            // Act
            feedback.SetRatingDate(date);

            // Assert
            Assert.AreEqual(date, feedback.RatingDate);
        }
        // public void SetContent(string content)
        [TestMethod]
        public void SetContent_ContentIsNull_ReturnFalse()
        {
            // Arrange
            var feedback = new Feedback();
            var content = "testContent";

            // Act
            feedback.SetContent(content);

            // Assert
            Assert.AreEqual(content, feedback.Content);
        }
        // public void SetScore(int score)
        [TestMethod]
        public void SetScore_ScoreIsNull_ReturnFalse()
        {
            // Arrange
            var feedback = new Feedback();
            var score = 1;

            // Act
            feedback.SetScore(score);

            // Assert
            Assert.AreEqual(score, feedback.Score);
        }
        // public Feedback(){}
        [TestMethod]
        public void Feedback_FeedbackIsNull_ReturnFalse()
        {
            // Arrange
            // act
            var feedback = new Feedback();

            // Assert
            Assert.IsNotNull(feedback);
        }
        
        
        
        
        
        
        
        
        
    }
}
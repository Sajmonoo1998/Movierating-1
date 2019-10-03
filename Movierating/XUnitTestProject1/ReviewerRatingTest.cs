using Moq;
using MovieRating.Core.ApplicationService;
using MovieRating.Core.ApplicationService.Impl;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace XUnitTestProject1
{
    public class ReviewerRatingTest
    {
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        public void CheckNumberOfReviewsByReviewer(int reviewer, int reviews)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating movieRating1 = new Rating(1, 0, 2, DateTime.Now);
            Rating movieRating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating movieRating3 = new Rating(2, 2, 2, DateTime.Now);
            Rating movieRating4 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(movieRating1);
            reviewerRatingRepository.Add(movieRating2);
            reviewerRatingRepository.Add(movieRating3);
            reviewerRatingRepository.Add(movieRating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            int actual = reviewerRatingService.ReviewerGradesAmount(reviewer);
            Assert.Equal(reviews, actual);
        }

        [Theory]
        [InlineData(1, 2.0)]
        [InlineData(2, 2.0)]
        [InlineData(3, 0)]
        public void CheckAverageGradeByReviewer(int reviewer, double avgGrade)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating movieRating1 = new Rating(1, 0, 2, DateTime.Now);
            Rating movieRating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating movieRating3 = new Rating(2, 2, 2, DateTime.Now);
            Rating movieRating4 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(movieRating1);
            reviewerRatingRepository.Add(movieRating2);
            reviewerRatingRepository.Add(movieRating3);
            reviewerRatingRepository.Add(movieRating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            double actual = reviewerRatingService.ReviewerAverageGrade(reviewer);
            Assert.Equal(avgGrade, actual);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 2, 3)]
        [InlineData(3, 3, 0)]
        public void CheckAmountOfParticularGradeGivenByReviewer(int reviewer, int grade, int expectedAmount)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating movieRating1 = new Rating(1, 0, 2, DateTime.Now);
            Rating movieRating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating movieRating3 = new Rating(2, 2, 2, DateTime.Now);
            Rating movieRating4 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(movieRating1);
            reviewerRatingRepository.Add(movieRating2);
            reviewerRatingRepository.Add(movieRating3);
            reviewerRatingRepository.Add(movieRating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            double actual = reviewerRatingService.AmountOfParticularGradeGivenByReviewer(reviewer, grade);
            Assert.Equal(expectedAmount, actual);
        }
        [Theory]
        [InlineData(1,2)]
        public void CheckTopReviewer(params int[]  expectedReviewer)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating movieRating1 = new Rating(1, 5, 3, DateTime.Now);
            Rating movieRating2 = new Rating(1, 6, 3, DateTime.Now);
            Rating movieRating3 = new Rating(1, 7, 3, DateTime.Now);
            Rating movieRating4 = new Rating(2, 1, 2, DateTime.Now);
            Rating movieRating5 = new Rating(2, 2, 2, DateTime.Now);
            Rating movieRating6 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(movieRating1);
            reviewerRatingRepository.Add(movieRating2);
            reviewerRatingRepository.Add(movieRating3);
            reviewerRatingRepository.Add(movieRating4);
            reviewerRatingRepository.Add(movieRating5);
            reviewerRatingRepository.Add(movieRating6);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            List<int> actual = reviewerRatingService.TopReviewer();
            Assert.Equal(expectedReviewer, actual);
        }
        [Fact]
        public void FailTopReviewer()
        {
            // Arrange
            var reviewerRatingRepository = new FakeReviewerRepo();
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
           

            // Act + Assert
            var e = Assert.Throws<Exception>(() =>
            {
             reviewerRatingService.TopReviewer();
            });

            Assert.True(e.Message == ("Database is empty."));
        }
        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 2, 3)]
        [InlineData(3, 3, 0)]
        public void CheckReviewerMoviesSortByGradDesc(params int[] expectedReviewer)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating movieRating1 = new Rating(1, 5, 3, DateTime.Now);
            Rating movieRating2 = new Rating(1, 6, 3, DateTime.Now);
            Rating movieRating3 = new Rating(1, 7, 3, DateTime.Now);
            Rating movieRating4 = new Rating(2, 1, 2, DateTime.Now);
            Rating movieRating5 = new Rating(2, 2, 2, DateTime.Now);
            Rating movieRating6 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(movieRating1);
            reviewerRatingRepository.Add(movieRating2);
            reviewerRatingRepository.Add(movieRating3);
            reviewerRatingRepository.Add(movieRating4);
            reviewerRatingRepository.Add(movieRating5);
            reviewerRatingRepository.Add(movieRating6);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            List<int> actual = reviewerRatingService.TopReviewer();
            Assert.Equal(expectedReviewer, actual);
        }



    }
}

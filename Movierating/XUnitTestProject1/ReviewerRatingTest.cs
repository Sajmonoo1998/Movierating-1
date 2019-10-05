using Moq;
using MovieRating.Core.ApplicationService;
using MovieRating.Core.ApplicationService.Impl;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public void GetReviewsAmountByReviewer_ValidInput(int reviewer, int reviews)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating rating = new Rating(1, 1, 2, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating rating3 = new Rating(2, 2, 2, DateTime.Now);
            Rating rating4 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(rating);
            reviewerRatingRepository.Add(rating2);
            reviewerRatingRepository.Add(rating3);
            reviewerRatingRepository.Add(rating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            int actual = reviewerRatingService.ReviewerGradesAmount(reviewer);
            Assert.Equal(reviews, actual);
        }

        [Theory]
        [InlineData(1, 2.0)]
        [InlineData(2, 2.0)]
        [InlineData(3, 0)]
        public void GetAverageGradeByReviewer_ValidInput(int reviewer, double avgGrade)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating rating = new Rating(1, 1, 2, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating rating3 = new Rating(2, 2, 2, DateTime.Now);
            Rating rating4 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(rating);
            reviewerRatingRepository.Add(rating2);
            reviewerRatingRepository.Add(rating3);
            reviewerRatingRepository.Add(rating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            double actual = reviewerRatingService.ReviewerAverageGrade(reviewer);
            Assert.Equal(avgGrade, actual);
        }

        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 2, 3)]
        [InlineData(3, 3, 0)]
        public void GetAmountOfParticularGradeGivenByReviewer_ValidInput(int reviewer, int grade, int expectedAmount)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating rating = new Rating(1, 1, 2, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating rating3 = new Rating(2, 2, 2, DateTime.Now);
            Rating rating4 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(rating);
            reviewerRatingRepository.Add(rating2);
            reviewerRatingRepository.Add(rating3);
            reviewerRatingRepository.Add(rating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            double actual = reviewerRatingService.AmountOfParticularGradeGivenByReviewer(reviewer, grade);
            Assert.Equal(expectedAmount, actual);
        }
        [Theory]
        [InlineData(1, 2)]
        public void GetTopReviewerOrReviewers_ValidInput(params int[] expectedReviewer)
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating rating = new Rating(1, 5, 3, DateTime.Now);
            Rating rating2 = new Rating(1, 6, 3, DateTime.Now);
            Rating rating3 = new Rating(1, 7, 3, DateTime.Now);
            Rating rating4 = new Rating(2, 1, 2, DateTime.Now);
            Rating rating5 = new Rating(2, 2, 2, DateTime.Now);
            Rating rating6 = new Rating(2, 3, 2, DateTime.Now);
            reviewerRatingRepository.Add(rating);
            reviewerRatingRepository.Add(rating2);
            reviewerRatingRepository.Add(rating3);
            reviewerRatingRepository.Add(rating4);
            reviewerRatingRepository.Add(rating5);
            reviewerRatingRepository.Add(rating6);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            List<int> actual = reviewerRatingService.TopReviewer();
            Assert.Equal(expectedReviewer, actual);
        }
        [Fact]
        public void TopReviewer_ThrowException()
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
        [Fact]    
        public void GetReviewerMoviesSortByGradDesc_ValidInput()
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating rating = new Rating(1, 5, 1, DateTime.Now.AddDays(10));
            Rating rating2 = new Rating(1, 6, 5, DateTime.Now.AddDays(9));
            Rating rating3 = new Rating(1, 7, 3, DateTime.Now);
            Rating rating4 = new Rating(1, 1, 5, DateTime.Now.AddDays(1));
            reviewerRatingRepository.Add(rating);
            reviewerRatingRepository.Add(rating2);
            reviewerRatingRepository.Add(rating3);
            reviewerRatingRepository.Add(rating4);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            List<Rating> expected = new List<Rating> { rating2, rating4, rating3, rating };//2431
            List<Rating> actual = reviewerRatingService.ReviewerMoviesSortByGradDesc(1).ToList();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetMovieRevieversSortByGradDesc_ValidInput()
        {
            var reviewerRatingRepository = new FakeReviewerRepo();
            Rating rating = new Rating(1, 10, 1, DateTime.Now.AddDays(10));
            Rating rating2 = new Rating(2, 10, 4, DateTime.Now.AddDays(9));
            Rating rating3 = new Rating(3, 10, 3, DateTime.Now);
            Rating rating4 = new Rating(4, 10, 5, DateTime.Now.AddDays(1));
            Rating rating5 = new Rating(5, 10, 5, DateTime.Now.AddDays(2));
            reviewerRatingRepository.Add(rating);
            reviewerRatingRepository.Add(rating2);
            reviewerRatingRepository.Add(rating3);
            reviewerRatingRepository.Add(rating4);
            reviewerRatingRepository.Add(rating5);
            IReviewerRatingService reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
            List<Rating> expected = new List<Rating> { rating5, rating4, rating2, rating3,rating };//2431
            List<Rating> actual = reviewerRatingService.MovieRevieversSortByGradDesc(10).ToList();
            Assert.Equal(expected, actual);
        }


    }
}

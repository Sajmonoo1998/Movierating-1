using PerformanceTest.Test_Fixtures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;
namespace PerformanceTest
{
   public class ReviewerRatingTest : IClassFixture<ReviewerRatingFixture>
    {
        private readonly ReviewerRatingFixture _reviewerRatingFixture;


        public ReviewerRatingTest(ReviewerRatingFixture reviewerRatingFixture)
        {
            _reviewerRatingFixture = reviewerRatingFixture;
        }
        [Fact]
        public void ReviewerGradesAmount_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _reviewerRatingFixture.reviewerRatingService.ReviewerGradesAmount(5));
            Assert.True(executionTime < 4.0);
        }
        [Fact]
        public void ReviewerAverageGrade_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _reviewerRatingFixture.reviewerRatingService.ReviewerAverageGrade(5));
            Assert.True(executionTime < 4.0);
        }
        [Fact]
        public void AmountOfParticularGradeGivenByReviewer_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _reviewerRatingFixture.reviewerRatingService.AmountOfParticularGradeGivenByReviewer(5,5));
            Assert.True(executionTime < 4.0);

        }
        [Fact]
        public void TopReviewer_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _reviewerRatingFixture.reviewerRatingService.TopReviewer());
            Assert.True(executionTime < 4.0);
        }
        [Fact]
        public void ReviewerMoviesSortByGradDesc_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _reviewerRatingFixture.reviewerRatingService.ReviewerMoviesSortByGradDesc(5));
            Assert.True(executionTime < 4.0);

        }
        [Fact]
        public void MovieRevieversSortByGradDesc_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _reviewerRatingFixture.reviewerRatingService.MovieRevieversSortByGradDesc(5));
            Assert.True(executionTime < 4.0);
        }

    }
}

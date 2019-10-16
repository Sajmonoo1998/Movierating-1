using PerformanceTest.Test_Fixtures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xunit;

namespace PerformanceTest
{
   public class MovieRatingTest : IClassFixture<MovieRatingFixture>
    {
        private readonly MovieRatingFixture _movieRatingFixture;


        public MovieRatingTest(MovieRatingFixture movieRatingFixture)
        {
            _movieRatingFixture = movieRatingFixture;
        }
        [Fact]
        public void MovieReviewsAmount_FourSecondsTest(){

            var executionTime = Timer.GetTime(() => _movieRatingFixture.movieRatingService.MovieReviewsAmount(5));
            Assert.True(executionTime < 4.0);

        }
        [Fact]
        public void MovieAverageGrade_FourSecondsTest()
        {         
           var executionTime = Timer.GetTime(()=>_movieRatingFixture.movieRatingService.MovieAverageGrade(5));
            Assert.True(executionTime < 4.0);
        }
        [Fact]
        public void GradeAmountInMovie_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _movieRatingFixture.movieRatingService.GradeAmountInMovie(1, 1));
            Assert.True(executionTime < 4.0);
        }
        [Fact]
        public void ListOfMoviesHavingTheMostFives_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _movieRatingFixture.movieRatingService.ListOfMoviesHavingTheMostFives());
            Assert.True(executionTime < 4.0);
        }
        [Fact]
        public void TopRatedMovies_FourSecondsTest()
        {
            var executionTime = Timer.GetTime(() => _movieRatingFixture.movieRatingService.TopRatedMovies(1));
            Assert.True(executionTime < 4.0);
        }

        

    }
}

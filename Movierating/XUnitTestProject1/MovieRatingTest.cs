using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using MovieRating.Core.Entities;
using MovieRating.Core.ApplicationService;
using MovieRating.Core.ApplicationService.Impl;
using System.Linq;

namespace XUnitTestProject1
{
   public class MovieRatingTest 
    {
        [Fact]
        public void GetMovieReviewsAmount_ValidInput()
        {
            var movieRatingRepository = new FakeMovieRepo();
            Rating rating = new Rating(1, 1, 2, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 2, DateTime.Now);
            Rating rating3 = new Rating(3, 1, 2, DateTime.Now);
            Rating rating4 = new Rating(4, 3, 2, DateTime.Now);
            movieRatingRepository.Add(rating);
            movieRatingRepository.Add(rating2);
            movieRatingRepository.Add(rating3);
            movieRatingRepository.Add(rating4);
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);
            int actual = movieRatingRepository.MovieReviewsAmount(1);
            Assert.Equal(3, actual);
        }
        [Fact]
        public void GetMovieAverageGrade_ValidInput()
        {
            var movieRatingRepository = new FakeMovieRepo();
            Rating rating = new Rating(1, 1, 1, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 3, DateTime.Now);
            Rating rating3 = new Rating(3, 1, 5, DateTime.Now);
            Rating rating4 = new Rating(4, 1, 5, DateTime.Now);
            movieRatingRepository.Add(rating);
            movieRatingRepository.Add(rating2);
            movieRatingRepository.Add(rating3);
            movieRatingRepository.Add(rating4);
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);
            double actual = movieRatingRepository.MovieAverageGrade(1);
            Assert.Equal(3.5, actual);
        }

        [Fact]
        public void GetGradeAmountInMovie_ValidInput()
        {
            var movieRatingRepository = new FakeMovieRepo();
            Rating rating = new Rating(1, 1, 5, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 5, DateTime.Now);
            Rating rating3 = new Rating(3, 1, 5, DateTime.Now);
            Rating rating4 = new Rating(4, 1, 5, DateTime.Now);
            movieRatingRepository.Add(rating);
            movieRatingRepository.Add(rating2);
            movieRatingRepository.Add(rating3);
            movieRatingRepository.Add(rating4);
            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);
            int actual = movieRatingRepository.GradeAmountInMovie(1, 5);
            Assert.Equal(4, actual);
        }
        [Fact]
        public void GetListOfMoviesHavingTheMostFives_ValidInput()
        {
            var movieRatingRepository = new FakeMovieRepo();
            Rating rating = new Rating(1, 1, 5, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 5, DateTime.Now);
            Rating rating3 = new Rating(3, 1, 5, DateTime.Now);
            Rating rating4 = new Rating(4, 1, 5, DateTime.Now);
            movieRatingRepository.Add(rating);
            movieRatingRepository.Add(rating2);
            movieRatingRepository.Add(rating3);
            movieRatingRepository.Add(rating4);
            movieRatingRepository.Add(new Rating(5, 1, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(6, 1, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(7, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(8, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(9, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(10, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(11, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(12, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(13, 3, 5, DateTime.Now));

            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);
            List<int> actual = movieRatingRepository.ListOfMoviesHavingTheMostFives().ToList();
            List<int> expected = new List<int>() { 1, 2 };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetTopRatedMovies_ValidInput()
        {
            var movieRatingRepository = new FakeMovieRepo();
            Rating rating = new Rating(1, 1, 1, DateTime.Now);
            Rating rating2 = new Rating(2, 1, 1, DateTime.Now);
            Rating rating3 = new Rating(3, 1, 1, DateTime.Now);
            Rating rating4 = new Rating(4, 1, 1, DateTime.Now);
            movieRatingRepository.Add(rating);
            movieRatingRepository.Add(rating2);
            movieRatingRepository.Add(rating3);
            movieRatingRepository.Add(rating4);
            movieRatingRepository.Add(new Rating(5, 1, 1, DateTime.Now));
            movieRatingRepository.Add(new Rating(6, 1, 1, DateTime.Now));
            movieRatingRepository.Add(new Rating(7, 2, 3, DateTime.Now));
            movieRatingRepository.Add(new Rating(8, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(9, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(10, 2, 4, DateTime.Now));
            movieRatingRepository.Add(new Rating(11, 2, 1, DateTime.Now));
            movieRatingRepository.Add(new Rating(12, 2, 5, DateTime.Now));
            movieRatingRepository.Add(new Rating(13, 3, 5, DateTime.Now));

            IMovieRatingService movieRatingService = new MovieRatingService(movieRatingRepository);
            List<int> actual = movieRatingRepository.TopRatedMovies(2);
            List<int> expected = new List<int>() { 3,2 };
            Assert.Equal(expected, actual);
        }
    }
}

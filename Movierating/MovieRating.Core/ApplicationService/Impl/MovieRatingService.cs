using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;

namespace MovieRating.Core.ApplicationService
{
    public class MovieRatingService : IMovieRatingService
    {
        private IMovieRatingRepository Repository;

        public MovieRatingService(IMovieRatingRepository repository)
        {
            Repository = repository;
        }
        public int GradeAmountInMovie(int movie, int grade) //
        {
            return Repository.GradeAmountInMovie(movie, grade);
        }

        public int MovieReviewsAmount(int movie) //
        {
            return Repository.MovieReviewsAmount(movie);
        }

        public double MovieAverageGrade(int movie)
        {
            return Repository.MovieAverageGrade(movie);
        }

       

        public List<int> ListOfMoviesHavingTheMostFives()
        {
            return Repository.ListOfMoviesHavingTheMostFives();
        }

        public List<int> TopRatedMovies(int amount)
        {
            return Repository.TopRatedMovies(amount);
        }
    }
}

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
        public int MovieGradeNumberOfReviews(int movie, int grade)
        {
            return Repository.MovieGradeNumberOfReviews(movie, grade);
        }

        public int AmountOfReviewsOfMovie(int movie)
        {
            return Repository.AmountOfReviewsOfMovie(movie);
        }

        public double MovieAverageGrade(int movie)
        {
            return Repository.MovieAverageGrade(movie);
        }

        public int AmountOfParticularGradeOfMovie(int movie, int grade)
        {
            return Repository.AmountOfParticularGradeOfMovie(movie, grade);
        }

        public List<int> ListOfMoviesHavingTheMostFives()
        {
            return Repository.ListOfMoviesHavingTheMostFives();
        }

        public List<int> TopRatedMoviesByAverageGrade(int amount)
        {
            return Repository.TopRatedMoviesByAverageGrade(amount);
        }
    }
}

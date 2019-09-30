using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;

namespace MovieRating.Core.ApplicationService
{
    public class MovieRatingService : IMovieRatingService
    {
        private IRepository Repository;

        public MovieRatingService(IRepository repository)
        {
            Repository = repository;
        }
        public int MovieGradeNumberOfReviews(int movie, int grade)
        {
            throw new NotImplementedException();
        }

        public int AmountOfReviewsOfMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public double MovieAverageGrade(int movie)
        {
            throw new NotImplementedException();
        }

        public int AmountOfParticularGradeOfMovie(int movie, int grade)
        {
            throw new NotImplementedException();
        }

        public List<int> ListOfMoviesHavingTheMostFives()
        {
            throw new NotImplementedException();
        }

        public List<int> TopRatedMoviesByAverageGrade(int amount)
        {
            throw new NotImplementedException();
        }
    }
}

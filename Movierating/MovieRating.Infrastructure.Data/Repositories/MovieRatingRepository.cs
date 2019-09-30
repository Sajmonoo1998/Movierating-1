using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;
namespace MovieRating.Infrastructure.Data.Repositories
{
    public class MovieRatingRepository : IMovieRatingRepository
    {
        public int AmountOfParticularGradeOfMovie(int movie, int grade)
        {
            throw new NotImplementedException();
        }

        public int AmountOfReviewsOfMovie(int movie)
        {
            throw new NotImplementedException();
        }

        public List<int> ListOfMoviesHavingTheMostFives()
        {
            throw new NotImplementedException();
        }

        public double MovieAverageGrade(int movie)
        {
            throw new NotImplementedException();
        }

        public int MovieGradeNumberOfReviews(int movie, int grade)
        {
            throw new NotImplementedException();
        }

        public List<int> TopRatedMoviesByAverageGrade(int amount)
        {
            throw new NotImplementedException();
        }
    }
}

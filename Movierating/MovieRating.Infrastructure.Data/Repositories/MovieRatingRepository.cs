using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;
namespace MovieRating.Infrastructure.Data.Repositories
{
    public class MovieRatingRepository : IMovieRatingRepository
    {
        public int GradeAmountInMovie(int movie, int grade)
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

        public int MovieReviewsAmount(int movie)
        {
            throw new NotImplementedException();
        }

        public List<int> TopRatedMovies(int amount)
        {
            throw new NotImplementedException();
        }
    }
}

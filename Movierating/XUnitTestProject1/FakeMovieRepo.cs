using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
   public class FakeMovieRepo : IMovieRatingRepository
    {
        private List<Rating> Ratings;

        public void Add(Rating r)
        {
            Ratings.Add(r);
        }
        /*
        public List<Rating> GetAllRatings()
        {
            List<Rating> l = new List<Rating>();
            l.AddRange(Ratings);
            return l;
        }*/
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

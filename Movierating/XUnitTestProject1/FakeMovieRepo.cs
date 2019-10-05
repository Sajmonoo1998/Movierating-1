using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitTestProject1
{
   public class FakeMovieRepo : IMovieRatingRepository
    {
        private readonly List<Rating> Ratings = new List<Rating>();

        public void Add(Rating r)
        {
            Ratings.Add(r);
        }
        public int GradeAmountInMovie(int movie, int grade)
        {
            return Ratings.Where(r => r.MovieId == movie && r.Grade == grade).Count();
        }

        public List<int> ListOfMoviesHavingTheMostFives()
        {
            /*   return Ratings.Where(r => r.Grade == 5)
           .GroupBy(r => r)
           .OrderByDescending(r => r.Count())
           .Select(r => r.Key );
          */

            List<int> topMovies = new List<int>();
            if (Ratings.Count == 0)
            {
                throw new Exception("Database is empty.");
            }
            else
            {
                foreach (var rating in Ratings)
                {
                    if (topMovies.Count == 0)
                        topMovies.Add(rating.MovieId);
                    else if (GradeAmountInMovie(topMovies[0],5) < GradeAmountInMovie(rating.MovieId,5))
                    {
                        topMovies = new List<int>();
                        topMovies.Add(rating.MovieId);
                    }
                    else if (!topMovies.Contains(rating.MovieId) && GradeAmountInMovie(topMovies[0],5) == GradeAmountInMovie(rating.MovieId,5))
                    {
                        topMovies.Add(rating.MovieId);
                    }
                }

            }
            return topMovies;
        }

        public double MovieAverageGrade(int movie)
        {
        return  Ratings.Where(r => r.MovieId == movie).Average(r => r.Grade);
        }

        public int MovieReviewsAmount(int movie)
        {
        return Ratings.Where(r => r.MovieId == movie).Count();
        }

        public List<int> TopRatedMovies(int amount)
        {
            return Ratings.OrderByDescending(r => MovieAverageGrade(r.MovieId))
                .Select(r => r.MovieId).Take(amount).Distinct().ToList();
              
        }
    }
}

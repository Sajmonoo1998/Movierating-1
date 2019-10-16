using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;


namespace MovieRating.Infrastructure.Data.Repositories
{
    public class MovieRatingRepository : IMovieRatingRepository
    {
        private readonly List<Rating> Ratings = new List<Rating>();

        public MovieRatingRepository(JsonFileRepository jsonFileRepository)
        {
            Ratings = jsonFileRepository.ReadData().ToList();
        }
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
              return Ratings.OrderByDescending(r => r.Grade).Select(r => r.MovieId).Distinct().ToList();
        }

        public double MovieAverageGrade(int movie)
        {
            return Ratings.Where(r => r.MovieId == movie).Select(r => r.Grade).DefaultIfEmpty(0).Average();
        }

        public int MovieReviewsAmount(int movie)
        {
            return Ratings.Where(r => r.MovieId == movie).Count();
        }

        public List<int> TopRatedMovies(int amount)
        {
            return Ratings.OrderByDescending(r => r.Grade).Select(r => r.MovieId).Distinct().Take(amount).ToList();
        }
    }
}

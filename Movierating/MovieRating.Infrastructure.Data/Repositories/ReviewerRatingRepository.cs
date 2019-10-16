using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class ReviewerRatingRepository : IReviewerRatingRepository
    {
        private readonly List<Rating> Ratings = new List<Rating>();

        public ReviewerRatingRepository(JsonFileRepository jsonFileRepository)
        {
            Ratings = jsonFileRepository.ReadData().ToList();
        }
        public void Add(Rating movieRating)
        {
            Ratings.Add(movieRating);
        }
        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            return Ratings.Where(r => r.ReviewerId == reviewer && r.Grade == grade).Count();
        }


        public double ReviewerAverageGrade(int reviewer)
        {
            return Ratings.Where(r => r.ReviewerId == reviewer).Select(r => r.Grade).DefaultIfEmpty(0).Average();
        }

        public int ReviewerGradesAmount(int reviewer)
        {
            return Ratings.Where(r => r.ReviewerId == reviewer).Count();
        }

        public IEnumerable<Rating> ReviewerMoviesSortByGradDesc(int reviewer)
        {
            return Ratings.Where(r => r.ReviewerId == reviewer).OrderByDescending(r => r.Grade).ThenByDescending(r => r.Date);
        }
        public IEnumerable<Rating> MovieRevieversSortByGradDesc(int movie)
        {
            return Ratings.Where(r => r.MovieId == movie).OrderByDescending(r => r.Grade).ThenByDescending(r => r.Date);
        }


        public List<int> TopReviewers()
        {
            return Ratings.GroupBy(r => r.ReviewerId).OrderByDescending(r => r.Count()).Select(r => r.Key).ToList();

        }
    }
}

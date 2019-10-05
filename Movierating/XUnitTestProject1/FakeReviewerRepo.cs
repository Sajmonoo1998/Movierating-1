using MovieRating.Core.ApplicationService;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitTestProject1
{
    public class FakeReviewerRepo : IReviewerRatingRepository
    {
       private readonly List<Rating> Ratings = new List<Rating>();

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
            List<int> topReviewers = new List<int>();
            if (Ratings.Count==0)
            {
              throw  new   Exception("Database is empty.");
            }
            else
            {
            foreach (var rating in Ratings)
            {
                    if (topReviewers.Count == 0)
                        topReviewers.Add(rating.ReviewerId);
                    else if (ReviewerGradesAmount(topReviewers[0]) < ReviewerGradesAmount(rating.ReviewerId))
                    {
                        topReviewers = new List<int>();
                        topReviewers.Add(rating.ReviewerId);
                    }
                    else if (!topReviewers.Contains(rating.ReviewerId) && ReviewerGradesAmount(topReviewers[0]) == ReviewerGradesAmount(rating.ReviewerId))
                    {
                        topReviewers.Add(rating.ReviewerId);
                    }
                }

            }
            return topReviewers;
            
        }

      
    }
}

using MovieRating.Core.ApplicationService;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
   public class FakeReviewerRepo : IReviewerRatingRepository
    {
        List<Rating> Ratings = new List<Rating>();

        public void Add(Rating movieRating)
        {
            Ratings.Add(movieRating);
        }
        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            var gradeAmount = 0;
            foreach (var rating in Ratings)
            {
                if (rating.ReviewerId == reviewer && rating.Grade == grade)
                    gradeAmount++;
            }
            return gradeAmount;
        }

        public List<int> MovieRevieversSortByGradDesc(int movie)
        {
            throw new NotImplementedException();
        }

        public double ReviewerAverageGrade(int reviewer)
        {
           
            int sumOfGrades = 0;
            int gradesAmount = ReviewerGradesAmount(reviewer);
            if (gradesAmount == 0)
                return 0;
            else
            {
                foreach (var rating in Ratings)
                {
                    if (rating.ReviewerId == reviewer)
                        sumOfGrades += rating.Grade;
                }
                return sumOfGrades / gradesAmount;
            }

        }

        public int ReviewerGradesAmount(int reviewer)
        {
            var reviewerGradesAmout = 0;
            foreach (var rating in Ratings)
            {
                if (rating.ReviewerId == reviewer)
                    reviewerGradesAmout++;
            }
            return reviewerGradesAmout;
        }

        public List<int> ReviewerMoviesSortByGradDesc(int reviewer)
        {
            throw new NotImplementedException();
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

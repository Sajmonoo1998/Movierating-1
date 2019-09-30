using MovieRating.Core.ApplicationService;
using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
   public class FakeReviewerRepo : IReviewerRatingService
    {
        List<Rating> movieRatings = new List<Rating>();

        public void Add(Rating movieRating)
        {
            movieRatings.Add(movieRating);
        }
        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            throw new NotImplementedException();
        }

        public List<int> MovieRevieversSortByGradDesc(int movie)
        {
            throw new NotImplementedException();
        }

        public double ReviewerAverageGrade(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int ReviewerGradesAmount(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> ReviewerMoviesSortByGradDesc(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int TopReviewer()
        {
            throw new NotImplementedException();
        }
    }
}

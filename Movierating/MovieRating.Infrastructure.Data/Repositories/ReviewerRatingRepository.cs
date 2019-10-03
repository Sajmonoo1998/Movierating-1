using MovieRating.Core.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class ReviewerRatingRepository : IReviewerRatingRepository
    {
        public double ReviewerAverageGrade(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> TopReviewers()
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

        public List<int> MovieRevieversSortByGradDesc(int movie)
        {
            throw new NotImplementedException();
        }

        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            throw new NotImplementedException();
        }
    }
}

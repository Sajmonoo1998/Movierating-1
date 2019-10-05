using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
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

        public IEnumerable<Rating> ReviewerMoviesSortByGradDesc(int reviewer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rating> MovieRevieversSortByGradDesc(int movie)
        {
            throw new NotImplementedException();
        }

        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            throw new NotImplementedException();
        }
    }
}

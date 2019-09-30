using MovieRating.Core.DomainService;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class ReviewerRatingRepository : IReviewerRatingRepository
    {
        public double ReviewerAverageGrading(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int ReviewerGivenMostReviews()
        {
            throw new NotImplementedException();
        }

        public int ReviewerGradesAmount(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> ReviewerRatedMoviesSortedByRateDescending(int reviewer)
        {
            throw new NotImplementedException();
        }

        public List<int> ReviewersWhoRatedMovieSortedByGradeGivenByReviewerDescending(int movie)
        {
            throw new NotImplementedException();
        }
    }
}

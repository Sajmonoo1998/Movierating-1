using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;

namespace MovieRating.Core.ApplicationService.Impl
{
    public class ReviewerRatingService : IReviewerRatingService
    {
        private IRepository Repository;

        public ReviewerRatingService(IRepository repository)
        {
            Repository = repository;
        }
        public int ReviewerGradesAmount(int reviewer)
        {
            throw new NotImplementedException();
        }

        public double ReviewerAverageGrading(int reviewer)
        {
            throw new NotImplementedException();
        }

        public int ReviewerGivenMostReviews()
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

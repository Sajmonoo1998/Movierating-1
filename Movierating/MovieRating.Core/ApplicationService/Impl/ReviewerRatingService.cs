using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;

namespace MovieRating.Core.ApplicationService.Impl
{
    public class ReviewerRatingService : IReviewerRatingService
    {
        private IReviewerRatingRepository Repository;

        public ReviewerRatingService(IReviewerRatingRepository repository)
        {
            Repository = repository;
        }
        public int ReviewerGradesAmount(int reviewer)
        {
            return Repository.ReviewerGradesAmount(reviewer);
        }

        public double ReviewerAverageGrading(int reviewer)
        {
            return Repository.ReviewerAverageGrading(reviewer);
        }

        public int ReviewerGivenMostReviews()
        {
            return Repository.ReviewerGivenMostReviews();
        }

        public List<int> ReviewerRatedMoviesSortedByRateDescending(int reviewer)
        {
            return Repository.ReviewerRatedMoviesSortedByRateDescending(reviewer);
        }

        public List<int> ReviewersWhoRatedMovieSortedByGradeGivenByReviewerDescending(int movie)
        {
            return Repository.ReviewersWhoRatedMovieSortedByGradeGivenByReviewerDescending(movie);
        }
    }
}

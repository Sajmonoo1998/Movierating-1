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

        public double ReviewerAverageGrade(int reviewer)
        {
            return Repository.ReviewerAverageGrade(reviewer);
        }

        public int TopReviewer()
        {
            return Repository.TopReviewer();
        }

        public List<int> ReviewerMoviesSortByGradDesc(int reviewer)
        {
            return Repository.ReviewerMoviesSortByGradDesc(reviewer);
        }

        public List<int> MovieRevieversSortByGradDesc(int movie)
        {
            return Repository.MovieRevieversSortByGradDesc(movie);
        }

        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            return Repository.AmountOfParticularGradeGivenByReviewer(int reviewer, int grade);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;

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

        public List<int> TopReviewer()
        {
            return Repository.TopReviewers();
        }

        public IEnumerable<Rating> ReviewerMoviesSortByGradDesc(int reviewer)
        {
            return Repository.ReviewerMoviesSortByGradDesc(reviewer);
        }

        public IEnumerable<Rating> MovieRevieversSortByGradDesc(int movie)
        {
            return Repository.MovieRevieversSortByGradDesc(movie);
        }

        public int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade)
        {
            return Repository.AmountOfParticularGradeGivenByReviewer( reviewer,  grade);
        }
    }
}

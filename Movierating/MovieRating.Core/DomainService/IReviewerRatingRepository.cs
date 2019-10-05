using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.DomainService
{
    public interface IReviewerRatingRepository
    {
        int ReviewerGradesAmount(int reviewer);
        double ReviewerAverageGrade(int reviewer);
        List<int> TopReviewers();
        int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade);
        IEnumerable<Rating> ReviewerMoviesSortByGradDesc(int reviewer);
        IEnumerable<Rating> MovieRevieversSortByGradDesc(int movie);
    }
}

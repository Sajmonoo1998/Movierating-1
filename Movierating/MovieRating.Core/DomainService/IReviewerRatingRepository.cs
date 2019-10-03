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
        List<int> ReviewerMoviesSortByGradDesc(int reviewer);
        List<int> MovieRevieversSortByGradDesc(int movie);
    }
}

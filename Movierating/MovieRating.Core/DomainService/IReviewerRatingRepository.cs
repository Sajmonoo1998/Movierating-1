using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.DomainService
{
    public interface IReviewerRatingRepository
    {
        int ReviewerGradesAmount(int reviewer);
        double ReviewerAverageGrade(int reviewer);
        int TopReviewer();
        int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade);
        List<int> ReviewerMoviesSortByGradDesc(int reviewer);
        List<int> MovieRevieversSortByGradDesc(int movie);
    }
}

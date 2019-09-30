using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.DomainService
{
    public interface IReviewerRatingRepository
    {
        int ReviewerGradesAmount(int reviewer);
        double ReviewerAverageGrading(int reviewer);
        int ReviewerGivenMostReviews();
        List<int> ReviewerRatedMoviesSortedByRateDescending(int reviewer);
        List<int> ReviewersWhoRatedMovieSortedByGradeGivenByReviewerDescending(int movie);
    }
}

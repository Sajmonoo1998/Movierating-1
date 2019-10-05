using MovieRating.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.ApplicationService
{
    public interface IReviewerRatingService
    {
        int ReviewerGradesAmount(int reviewer); // 1 
        double ReviewerAverageGrade(int reviewer); // 2 
        int AmountOfParticularGradeGivenByReviewer(int reviewer, int grade); // 3
        List<int> TopReviewer(); // 8
        IEnumerable<Rating> ReviewerMoviesSortByGradDesc(int reviewer); // 10 
        IEnumerable<Rating> MovieRevieversSortByGradDesc(int movie); // 11
    }
}

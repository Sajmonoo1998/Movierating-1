using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;

namespace MovieRating.Core.ApplicationService
{
    public interface IMovieRatingService
    {
        int MovieReviewsAmount(int movie); // 4
        double MovieAverageGrade(int movie); // 5
        int GradeAmountInMovie(int movie, int grade); // 6
        
        List<int> ListOfMoviesHavingTheMostFives(); // 7 
        List<int> TopRatedMovies(int amount);// 9
    }
}

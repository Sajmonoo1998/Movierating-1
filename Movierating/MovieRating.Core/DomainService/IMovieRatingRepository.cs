using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.DomainService
{
    public interface IMovieRatingRepository
    {
        int GradeAmountInMovie(int movie, int grade); //
        int MovieReviewsAmount(int movie);//
        double MovieAverageGrade(int movie);
        List<int> ListOfMoviesHavingTheMostFives();
        List<int> TopRatedMovies(int amount);
    }
}

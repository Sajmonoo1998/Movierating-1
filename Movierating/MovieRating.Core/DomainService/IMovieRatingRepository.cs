using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.DomainService
{
    public interface IMovieRatingRepository
    {
        int MovieGradeNumberOfReviews(int movie, int grade);
        int AmountOfReviewsOfMovie(int movie);
        double MovieAverageGrade(int movie);
        int AmountOfParticularGradeOfMovie(int movie, int grade);
        List<int> ListOfMoviesHavingTheMostFives();
        List<int> TopRatedMoviesByAverageGrade(int amount);
    }
}

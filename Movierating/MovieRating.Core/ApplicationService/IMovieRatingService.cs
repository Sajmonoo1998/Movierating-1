using System;
using System.Collections.Generic;
using System.Text;
using MovieRating.Core.DomainService;

namespace MovieRating.Core.ApplicationService
{
    public interface IMovieRatingService
    {
        int MovieGradeNumberOfReviews(int movie, int grade);
        int AmountOfReviewsOfMovie(int movie);
        double MovieAverageGrade(int movie);
        int AmountOfParticularGradeOfMovie(int movie, int grade);
        List<int> ListOfMoviesHavingTheMostFives();
        List<int> TopRatedMoviesByAverageGrade(int amount);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.Entities
{
    public class Rating
    {
        public int ReviewerId { get; private set; }

        public int MovieId { get; private set; }

        public int Grade { get; private set; }

        public DateTime Date { get; private set; }

        public Rating(int reviewerId, int movieId, int grade, DateTime date)
        {
            ReviewerId = reviewerId;
            MovieId = movieId;
            Grade = grade;
            Date = date;
        }
    }
}

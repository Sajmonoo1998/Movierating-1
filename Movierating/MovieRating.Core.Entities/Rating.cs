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
            
         //   if (reviewerId > 0)
                ReviewerId = reviewerId;
        //    else throw new Exception("Reviewer ID has to be positive number.");

        //    if (movieId > 0)
                MovieId = movieId;
         //   else throw new Exception("Movie ID has to be positive number.");

        //    if (grade > 0 && grade < 6)
                Grade = grade;
        //    else throw new Exception("You can grade only from 1 to 5.");

            Date = date;
        }
        
    }
}

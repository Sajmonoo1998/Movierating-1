using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating.Core.Entities
{
    public class MovieRating
    {
        public int RevieverID { get; set; }
        public int MovieID { get; set; }

        public int Grade { get; set; }

        public DateTime Date { get; set; }
    }
}

using MovieRating.Core.ApplicationService;
using MovieRating.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerformanceTest.Test_Fixtures
{
  public  class MovieRatingFixture : IDisposable
    {
        public MovieRatingService movieRatingService { get; private set; }

        public MovieRatingFixture()
        {
            MovieRatingRepository movieRatingRepository = new MovieRatingRepository(new JsonFileRepository());
            movieRatingService = new MovieRatingService(movieRatingRepository);
        }

        public void Dispose()
        {
            movieRatingService = null;
        }
    }
}

using MovieRating.Core.ApplicationService.Impl;
using MovieRating.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PerformanceTest.Test_Fixtures
{
   public class ReviewerRatingFixture : IDisposable
    {
        public ReviewerRatingService reviewerRatingService { get; private set; }

		public ReviewerRatingFixture()
		{
			ReviewerRatingRepository reviewerRatingRepository = new ReviewerRatingRepository(new JsonFileRepository());
            reviewerRatingService = new ReviewerRatingService(reviewerRatingRepository);
		}

		public void Dispose()
		{
            reviewerRatingService = null;
		}
    }
}

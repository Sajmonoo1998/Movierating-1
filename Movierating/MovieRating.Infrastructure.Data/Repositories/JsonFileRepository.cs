using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MovieRating.Core.DomainService;
using MovieRating.Core.Entities;
using Newtonsoft.Json;

namespace MovieRating.Infrastructure.Data.Repositories
{
    public class JsonFileRepository
    {
        private string path = @"..\..\..\..\ratings.json";


        public IEnumerable<Rating> ReadData()
        {
            return JsonConvert.DeserializeObject<IEnumerable<Rating>>(File.ReadAllText(path));
             
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HotChocolate;
using ConferencePlanner.GraphQL.Data;

namespace GraphQL
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }
}

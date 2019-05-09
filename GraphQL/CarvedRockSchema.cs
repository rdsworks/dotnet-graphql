using GraphQL.Types;
using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CarvedRock.Api.GraphQL {
    public class CarvedRockSchema : Schema {
        public CarvedRockSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<CarvedRockQuery>();
        }
    }
}
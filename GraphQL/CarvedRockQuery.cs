using GraphQL.Types;
using CarvedRock.Api.Repositories;
using CarvedRock.Api.GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRock.GraphQL.Types;


namespace CarvedRock.Api.GraphQL {
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
            );
        }
    }
}
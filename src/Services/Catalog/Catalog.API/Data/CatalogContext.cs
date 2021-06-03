﻿using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionStrings"));
            var database = client.GetDatabase("DatabaseSettings:DatabaseName");

            Products = database.GetCollection<Product>("DatabaseSettings:CollectionName");

           CatalogContextSeed.SeedData(Products);
        }


        public IMongoCollection<Product> Products { get; }
    }
}

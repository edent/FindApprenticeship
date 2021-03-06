﻿namespace AddressLoader.Mongo
{
    using MongoDB.Driver;
    using MongoDB.Driver.Builders;

    public class MongoAddressProvider
    {
        private readonly MongoCollection<MongoAddressWrapper> _collection;

        public MongoAddressProvider(string mongoConnectionString, string mongoDatabaseName, string mongoCollectionName)
        {
            _collection = new MongoClient(mongoConnectionString)
                .GetServer()
                .GetDatabase(mongoDatabaseName)
                .GetCollection<MongoAddressWrapper>(mongoCollectionName);
        }

        public MongoCursor<MongoAddressWrapper> AllResidentialAddresses
        {
            get
            {
                var query = Query.EQ("details.isResidential", true);
                return _collection.Find(query);
            }
        }
    }
}
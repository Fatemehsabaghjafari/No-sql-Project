﻿using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;
namespace DAL
{
    public class DAO
    {
        private MongoClient client;
        protected IMongoDatabase database;
        protected IMongoCollection<Ticket> collection;


        public DAO()
        {
            client = new MongoClient("mongodb+srv://mahbaan77:stBmNXvZNQDwVllz@cluster0.uwmve3e.mongodb.net/DemoChart?retryWrites=true&w=majority");
            database = client.GetDatabase("assignment1"); // Specify your database name here
            collection = database.GetCollection<Ticket>("Garden-group"); // Specify your collection name here
        }

        public List<Databases_Model> GetDatabases()
        {
            List<Databases_Model> all_databases = new List<Databases_Model>();
            
            foreach (BsonDocument db in client.ListDatabases().ToList())
            {
                all_databases.Add(BsonSerializer.Deserialize<Databases_Model>(db));
            }
            return all_databases;
        }
    }


}
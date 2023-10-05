using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using Model;
using MongoDB.Bson.Serialization;


namespace DAL
{
    public class EmployeeDao : DAO
    {
        private MongoClient User;
        protected IMongoDatabase database;
        private readonly IMongoCollection<Employee> collection;

        public EmployeeDao()
        {
            User = new MongoClient("mongodb+srv://mahbaan77:stBmNXvZNQDwVllz@cluster0.uwmve3e.mongodb.net/DemoChart?retryWrites=true&w=majority");
            database = User.GetDatabase("assignment1"); // Specify your database name here
            collection = database.GetCollection<Employee>("employee"); // Specify your collection name here
        }

        public void InsertUser(Employee user)
        {
            collection.InsertOne(user);
        }

    }
}

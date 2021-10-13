using MongoDB.Driver;
using MongoDBInCSharp.Models;
using System;

namespace MongoDBInCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("mdb-omg");

            var productsDB = database.GetCollection<Product>("products");
            var product = new Product() { Name = "Alfajor", Price = 120, UnitOfMeasure = "gramos", Weigth = 80 };
            productsDB.InsertOne(product);

            Console.WriteLine("Todo OK");
        }
    }
}

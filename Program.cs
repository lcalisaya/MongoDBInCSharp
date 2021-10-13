using MongoDB.Driver;
using MongoDBInCSharp.Models;
using System;
using System.Collections.Generic;

namespace MongoDBInCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            var database = client.GetDatabase("mdb-omg");

            var productsDB = database.GetCollection<Product>("products");

            //INSERT
            //var product = new Product() { Name = "Alfombra", Price = 2000, UnitOfMeasure = "gramos", Weigth = 1000 };
            //productsDB.InsertOne(product);

            //GET
            List<Product> products = productsDB.Find(f => true).ToList();
            foreach (Product p in products)
            {
                Console.WriteLine("Name: " + p.Name + " Price: $" + p.Price);
            }

            //UPDATE
            //var product = new Product() { Id= "61674644ad0773e4d171083e", Name = "Alfombra editada", Price = 2000, UnitOfMeasure = "kilos", Weigth = 1000 };
            //productsDB.ReplaceOne(r => r.Id == "61674644ad0773e4d171083e", product);

            //DELETE
            productsDB.DeleteOne(d => d.Id == "61674644ad0773e4d171083e");


        }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBInCSharp.Models
{
    public class Product
    {
        [BsonId] //Key field
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("weigth")]
        public int Weigth { get; set; }
        [BsonElement("unitOfMeasure")]
        public string UnitOfMeasure { get; set; }
    }
}

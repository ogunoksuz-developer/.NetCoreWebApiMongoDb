using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public abstract class MongoDbEntity : IEntity<string>
    {

        //[BsonRepresentation(BsonType.ObjectId)]
        //[BsonId]
        //[BsonElement(Order = 0)]
        //public string Id { get; } = ObjectId.GenerateNewId().ToString();

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }



    }
}

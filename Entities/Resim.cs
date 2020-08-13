using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entities
{
   public class Resim: MongoDbEntity
    {
        [BsonElement("Url")]
        public string Url { get; set; }
    }
}

using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Malzeme: MongoDbEntity
    {
        [BsonElement("Ad")]
        public string Ad { get; set; }
    }
}

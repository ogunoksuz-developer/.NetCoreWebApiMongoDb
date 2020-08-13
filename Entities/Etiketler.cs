using Core.Entities;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Etiketler: MongoDbEntity
    {
        [BsonElement("Ad")]
        public string Ad { get; set; }
    }
}

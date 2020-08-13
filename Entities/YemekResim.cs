using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class YemekResim:MongoDbEntity
    {
        [BsonElement("YemekId")]
        public string YemekId { get; set; }

        [BsonElement("ResimId")]
        public string ResimId { get; set; }
    }
}

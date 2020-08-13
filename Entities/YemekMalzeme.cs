using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class YemekMalzeme : MongoDbEntity
    {
        [BsonElement("YemekId")]
        public string YemekId { get; set; }

        [BsonElement("MalzemeId")]
        public string MalzemeId { get; set; }
    }
}

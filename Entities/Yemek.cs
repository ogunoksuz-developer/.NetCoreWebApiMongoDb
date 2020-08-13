using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Yemek:MongoDbEntity
    {
        [BsonElement("YemekId")]
        public int YemekId { get; set; }

        [BsonElement("YemekAd")]
        public string YemekAd { get; set; }

        [BsonElement("Tarif")]
        public string Tarif { get; set; }

        [BsonElement("TurId")]
        public int TurId { get; set; }
    }
}

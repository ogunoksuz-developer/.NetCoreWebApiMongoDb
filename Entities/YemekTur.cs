using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class YemekTur: MongoDbEntity
    {

        [BsonElement("TurId")]
        public int TurId { get; set; }

        [BsonElement("TurAd")]
        public string TurAd { get; set; }

    }
}

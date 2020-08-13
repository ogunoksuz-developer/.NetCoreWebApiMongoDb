using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.MongoDb;
using Core.Entities;
using DataAccess.Abstract;
using Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DataAccess.Concrete.MongoDb
{
   public class MdYemekMalzemeDal: MdEntityRepositoryBase<YemekMalzeme>, IYemekMalzemeDal
    {
        protected readonly IMongoCollection<YemekMalzeme> Collection1;
        protected readonly IMongoCollection<Malzeme> Collection2;
        private readonly MongoDbSettings settings;

        public MdYemekMalzemeDal(IOptions<MongoDbSettings> options) : base(options)
        {
            this.settings = options.Value;
            var client = new MongoClient(this.settings.ConnectionString);
            var db = client.GetDatabase(this.settings.Database);
            this.Collection1 = db.GetCollection<YemekMalzeme>("YemekMalzeme");
            this.Collection2 = db.GetCollection<Malzeme>("Malzeme");
        }

        public List<Malzeme> GetMalzemeByYemekId(string yemekId)
        {
            var result = Collection1.Find(x => x.YemekId == yemekId).ToList();
            List<Malzeme> malzeme = new List<Malzeme>();
            foreach (var item in result)
            {
                var result2 = Collection2.Find(x => x.Id == item.MalzemeId).FirstOrDefault();
                malzeme.Add(result2);
            }

            return malzeme;
        }
    }
}

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
   public class MdYemekResimDal: MdEntityRepositoryBase<YemekResim>, IYemekResimDal
    {
        protected readonly IMongoCollection<YemekResim> Collection1;
        protected readonly IMongoCollection<Resim> Collection2;
        private readonly MongoDbSettings settings;

        public MdYemekResimDal(IOptions<MongoDbSettings> options) : base(options)
        {
            this.settings = options.Value;
            var client = new MongoClient(this.settings.ConnectionString);
            var db = client.GetDatabase(this.settings.Database);
            this.Collection1 = db.GetCollection<YemekResim>("YemekResim");
            this.Collection2 = db.GetCollection<Resim>("Resim");
        }

        public List<Resim> GetResimByYemId(string yemekId)
        {
            var result = Collection1.Find(x => x.YemekId == yemekId).ToList();
            List<Resim> resim = new List<Resim>();
            foreach (var item in result)
            {
                var result2 = Collection2.Find(x => x.Id == item.ResimId).FirstOrDefault();
                resim.Add(result2);
            }

            return resim;
        }
    }
}

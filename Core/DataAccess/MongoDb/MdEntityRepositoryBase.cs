
using Core.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;



namespace Core.DataAccess.MongoDb
{
    public abstract class MdEntityRepositoryBase<T> : IEntityRepository<T, string> where T : MongoDbEntity, new()
    {
        protected readonly IMongoCollection<T> Collection;
        private readonly MongoDbSettings settings;

        protected MdEntityRepositoryBase(IOptions<MongoDbSettings> options)
        {
            this.settings = options.Value;
            var client = new MongoClient(this.settings.ConnectionString);
            var db = client.GetDatabase(this.settings.Database);
            this.Collection = db.GetCollection<T>(typeof(T).Name);
        }

        public T Add(T entity)
        {
            var options = new InsertOneOptions { BypassDocumentValidation = false };
            Collection.InsertOne(entity, options);
            return entity;
        }

        public T Delete(T entity)
        {
            return Collection.FindOneAndDelete(x => x.Id == entity.Id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null
     ? Collection.AsQueryable()
     : Collection.AsQueryable().Where(predicate);

        }

        public T GetById(string id)
        {
            var result= Collection.Find(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public T Update(string id, T entity)
        {
            return  Collection.FindOneAndReplace(x => x.Id == id, entity);
        }
    }
}

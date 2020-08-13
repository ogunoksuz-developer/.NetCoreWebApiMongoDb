using Core.DataAccess.MongoDb;
using DataAccess.Abstract;
using Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.Extensions.Options;

namespace DataAccess.Concrete.MongoDb
{
    public class MdYemekDal : MdEntityRepositoryBase<Yemek>, IYemekDal
    {
        public MdYemekDal(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}

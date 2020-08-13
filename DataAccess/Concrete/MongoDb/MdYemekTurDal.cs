using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.MongoDb;
using Core.Entities;
using DataAccess.Abstract;
using Entities;
using Microsoft.Extensions.Options;

namespace DataAccess.Concrete.MongoDb
{
    public class MdYemekTurDal: MdEntityRepositoryBase<YemekTur>, IYemekTurDal
    {
        public MdYemekTurDal(IOptions<MongoDbSettings> options) : base(options)
        {
        }
    }
}

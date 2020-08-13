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
    public class MdMalzemeDal: MdEntityRepositoryBase<Malzeme>, IMalzemeDal
    {
        public MdMalzemeDal(IOptions<MongoDbSettings> options) : base(options)
        {

        }
    }
}

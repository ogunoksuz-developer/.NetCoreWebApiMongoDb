using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using MongoDB.Bson;

namespace DataAccess.Abstract
{
   public interface IYemekTurDal: IEntityRepository<YemekTur, string>
    {
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities;

namespace DataAccess.Abstract
{
   public interface IYemekMalzemeDal : IEntityRepository<YemekMalzeme, string>
    {
        List<Malzeme> GetMalzemeByYemekId(string yemekId);
    }
}

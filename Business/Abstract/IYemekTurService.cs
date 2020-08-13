using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IYemekTurService
    {
        List<YemekTur> GetList();

        YemekTur GetById(string id);

        YemekTur Add(YemekTur entity);

        YemekTur Update(string id, YemekTur entity);

        YemekTur Delete(YemekTur entity);
    }
}

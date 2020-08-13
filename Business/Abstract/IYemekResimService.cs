using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IYemekResimService
    {
        List<YemekResim> GetList();

        YemekResim GetById(string id);

        YemekResim Add(YemekResim entity);

        YemekResim Update(string id, YemekResim entity);

        YemekResim Delete(YemekResim entity);

        List<Resim> GetResimByYemId(string yemekId);
    }
}

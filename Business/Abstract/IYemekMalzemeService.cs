using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYemekMalzemeService
    {
        List<YemekMalzeme> GetList();

        YemekMalzeme GetById(string id);

        YemekMalzeme Add(YemekMalzeme entity);

        YemekMalzeme Update(string id, YemekMalzeme entity);

        YemekMalzeme Delete(YemekMalzeme entity);

        List<Malzeme> GetMalzemeByYemekId(string yemekId);
    }
}

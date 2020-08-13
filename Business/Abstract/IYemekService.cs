using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IYemekService
    {
        List<Yemek> GetList();

        Yemek GetById(string id);

        Yemek Add(Yemek entity);

        Yemek Update(string id, Yemek entity);

        Yemek Delete(Yemek entity);

    }
}

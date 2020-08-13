using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class YemekMalzemeManager : IYemekMalzemeService
    {
        private readonly IYemekMalzemeDal _yemekMalzemeDal;

        public YemekMalzemeManager(IYemekMalzemeDal yemekMalzemeDal)
        {
            _yemekMalzemeDal = yemekMalzemeDal;
        }

        public YemekMalzeme Add(YemekMalzeme entity)
        {
            return _yemekMalzemeDal.Add(entity);
        }

        public YemekMalzeme Delete(YemekMalzeme entity)
        {
            return _yemekMalzemeDal.Delete(entity);
        }

        public YemekMalzeme GetById(string id)
        {
            return _yemekMalzemeDal.GetById(id);
        }

        public List<YemekMalzeme> GetList()
        {
            return _yemekMalzemeDal.Get().ToList();
        }

        public List<Malzeme> GetMalzemeByYemekId(string yemekId)
        {
            return _yemekMalzemeDal.GetMalzemeByYemekId(yemekId);
        }

        public YemekMalzeme Update(string id, YemekMalzeme entity)
        {
            return _yemekMalzemeDal.Update(id, entity);
        }

     
      

     
    }
}

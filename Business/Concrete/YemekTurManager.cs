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
    public class YemekTurManager : IYemekTurService
    {
        private IYemekTurDal _yemekTurDal ;

        public YemekTurManager(IYemekTurDal yemekTurDal)
        {
            _yemekTurDal = yemekTurDal;
        }


        public YemekTur Add(YemekTur entity)
        {
            return _yemekTurDal.Add(entity);
        }

        public YemekTur Delete(YemekTur entity)
        {
            return _yemekTurDal.Delete(entity);
        }

        public List<YemekTur> GetList()
        {
            return _yemekTurDal.Get().ToList();
        }

        public YemekTur GetById(string id)
        {
            return _yemekTurDal.GetById(id);
        }

        public YemekTur Update(string id, YemekTur entity)
        {
            return _yemekTurDal.Update(id, entity);
        }
    }
}

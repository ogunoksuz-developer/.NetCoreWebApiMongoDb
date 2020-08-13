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
    public class YemekResimManager : IYemekResimService
    {
        private readonly IYemekResimDal _yemekResimDal;

        public YemekResimManager(IYemekResimDal yemekResimDal )
        {
            _yemekResimDal = yemekResimDal;
        }

        public YemekResim Add(YemekResim entity)
        {
            return _yemekResimDal.Add(entity);
        }

        public YemekResim Delete(YemekResim entity)
        {
            return _yemekResimDal.Delete(entity);
        }

        public YemekResim GetById(string id)
        {
            return _yemekResimDal.GetById(id);
        }

        public List<YemekResim> GetList()
        {
            return _yemekResimDal.Get().ToList();
        }

        public List<Resim> GetResimByYemId(string yemekId)
        {
            return _yemekResimDal.GetResimByYemId(yemekId);
        }

        public YemekResim Update(string id, YemekResim entity)
        {
            return _yemekResimDal.Update(id, entity);
        }
    }
}

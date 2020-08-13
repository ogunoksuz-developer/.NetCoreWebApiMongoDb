using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class YemekManager : IYemekService
    {
        private readonly IYemekDal _yemekDal;

        public YemekManager(IYemekDal yemekDal)
        {
            _yemekDal = yemekDal;
        }

        public Yemek Add(Yemek entity)
        {
            return _yemekDal.Add(entity);
        }

        public Yemek Delete(Yemek entity)
        {
            return _yemekDal.Delete(entity);
        }

        public Yemek GetById(string id)
        {
            return _yemekDal.GetById(id);
        }

        public List<Yemek> GetList()
        {
            return _yemekDal.Get().ToList();
        }

        public Yemek Update(string id, Yemek entity)
        {
            return _yemekDal.Update(id, entity);
        }
    }
}

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
    public class MalzameManager:IMalzemeService
    {
        private IMalzemeDal _malzemeDal;

        public MalzameManager(IMalzemeDal malzemeDal)
        {
            _malzemeDal = malzemeDal;
        }

        public Malzeme Add(Malzeme entity)
        {
            return _malzemeDal.Add(entity);
        }

        public Malzeme Delete(Malzeme entity)
        {
            return _malzemeDal.Delete(entity);
        }

        public Malzeme GetById(string id)
        {
            return _malzemeDal.GetById(id);
        }

        public List<Malzeme> GetList()
        {
            return _malzemeDal.Get().ToList();
        }

        public Malzeme Update(string id, Malzeme entity)
        {
            return _malzemeDal.Update(id, entity);
        }
    }
}

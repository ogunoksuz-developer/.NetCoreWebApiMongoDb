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
    public class ResimManager:IResimService
    {
        private IResimDal _resimDal;
        public ResimManager(IResimDal resimDal)
        {
            _resimDal = resimDal;
        }

        public Resim Add(Resim entity)
        {
            return _resimDal.Add(entity);
        }

        public Resim Delete(Resim entity)
        {
            return _resimDal.Delete(entity);
        }

        public Resim GetById(string id)
        {
            return _resimDal.GetById(id);
        }

        public List<Resim> GetList()
        {
            return _resimDal.Get().ToList();
        }

        public Resim Update(string id, Resim entity)
        {
            return _resimDal.Update(id, entity);
        }
    }
}

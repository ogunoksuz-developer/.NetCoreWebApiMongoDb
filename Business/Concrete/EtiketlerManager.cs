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
    public class EtiketlerManager:IEtiketlerService
    {
        private IEtiketlerDal _etiketlerDal;

        public EtiketlerManager(IEtiketlerDal etiketlerDal)
        {
            _etiketlerDal = etiketlerDal;
        }

        public Etiketler Add(Etiketler entity)
        {
            return _etiketlerDal.Add(entity);
        }

        public Etiketler Delete(Etiketler entity)
        {
            return _etiketlerDal.Delete(entity);
        }

        public Etiketler GetById(string id)
        {
            return _etiketlerDal.GetById(id);
        }

        public List<Etiketler> GetList()
        {
            return _etiketlerDal.Get().ToList();
        }

        public Etiketler Update(string id, Etiketler entity)
        {
            return _etiketlerDal.Update(id, entity);
        }
    }
}

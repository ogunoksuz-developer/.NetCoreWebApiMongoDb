using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEtiketlerService
    {
        List<Etiketler> GetList();

        Etiketler GetById(string id);

        Etiketler Add(Etiketler entity);

        Etiketler Update(string id, Etiketler entity);

        Etiketler Delete(Etiketler entity);
    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IResimService
    {
        List<Resim> GetList();

        Resim GetById(string id);

        Resim Add(Resim entity);

        Resim Update(string id, Resim entity);

        Resim Delete(Resim entity);
    }
}

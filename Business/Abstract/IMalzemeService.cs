using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IMalzemeService
    {
        List<Malzeme> GetList();

        Malzeme GetById(string id);

        Malzeme Add(Malzeme entity);

        Malzeme Update(string id, Malzeme entity);

        Malzeme Delete(Malzeme entity);
    }
}

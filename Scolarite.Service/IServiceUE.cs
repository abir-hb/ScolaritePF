using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public interface IServiceUE :IService<EspUe>
    {


        public EspUe GetUEByID(string UeId);
        void Delete(string id);

        void CreateUe(EspUe m);
        void UpdateUe(EspUe m);
    }
}

using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Service
{
    public interface IServiceUp :IService<EspUp>
    {
        public EspUp GetUpByID(string up);
        public IEnumerable<EspUp> GetAllUp();
    }
}

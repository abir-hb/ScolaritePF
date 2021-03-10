using Scolarite.Domain.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scolarite.Data.Infrastructures
{
    public interface IDataBaseFactory : IDisposable
    {
      ModelContext DataContext { get; }
    }
}

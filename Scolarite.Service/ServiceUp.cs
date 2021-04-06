using Microsoft.Extensions.Logging;
using Scolarite.Data.Infrastructures;
using Scolarite.Domain.entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scolarite.Service
{
    public class ServiceUp : Service<EspUp>, IServiceUp
    {

        public static DataBaseFactory dbf = new DataBaseFactory();
        public static IUnitOfWork uow = new UnitOfWork(dbf);
        public readonly ModelContext context;
        public readonly ILogger<ServiceUp> logger;

        public ServiceUp() : base(uow)
        {
        }
        //public ServiceUp(ModelContext ctx, ILogger<ServiceUp> log )
        //{
        //    context = ctx;
        //    logger = log;
        //}
        public IEnumerable<EspUp> GetAllUp()
        {
            try
            {
                logger.LogInformation("GetAll UP");
                return context.EspUp
                    .OrderBy(p => p.Up)
                    .ToList();
                    


            }
            catch(Exception ex)
            {
                logger.LogError($"Failed to get All:{ex}");
                return null;
            }
        }
        public EspUp GetUpByID(string up)
        {
            return GetAll().FirstOrDefault(m => m.Up == up);
        }
    }
}

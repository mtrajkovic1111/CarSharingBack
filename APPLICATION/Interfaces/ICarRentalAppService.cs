using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.Interfaces
{
   public interface ICarRentalAppService : IAppServiceBase<CarRental>
    {
        IQueryable<CarRental> GetAllWithRelatedTables();
        IQueryable<CarRental> GetAllByIdWithRelatedTables(int id);
        IQueryable<CarRental> GetAllByUserId(int id);

    }
}

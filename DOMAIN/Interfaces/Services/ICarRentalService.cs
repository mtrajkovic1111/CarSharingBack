using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Services
{
    public interface ICarRentalService : IServiceBase<CarRental>
    {
        IQueryable<CarRental> GetAllWithRelatedTables();
        IQueryable<CarRental> GetAllByIdWithRelatedTables(int id);
        IQueryable<CarRental> GetAllByUserId(int id);
    }
}

using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Repositories
{
    public interface ICarRentalRepository : IRepositoryBase<CarRental>
    {
        IQueryable<CarRental> GetAllWithRelatedTables();
        IQueryable<CarRental> GetAllByIdWithRelatedTables(int id);
        IQueryable<CarRental> GetAllByUserId(int id);
    }
}

using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class CarRentalRepository : RepositoryBase<CarRental>, ICarRentalRepository
    {
        public CarRentalRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<CarRental> GetAllByIdWithRelatedTables(int id)
        {
            return context.CarRentals.Where(m => m.Id == id)
                .Include(m => m.Car)
                .Include(m => m.Car.Vehicle.Model.Brand)
                .Include(m => m.Car.Vehicle.Variant)
                .Include(m =>m.Car.User)
                .Include(m => m.User).OrderBy(c => c.FromDate);
        }

        public IQueryable<CarRental> GetAllWithRelatedTables()
        {
            return context.CarRentals
                .Include("Car")
                .Include("Car.Vehicle.Model.Brand")
                .Include("Car.Vehicle.Variant")
                .Include("User").OrderBy(c => c.FromDate);
     
        }

        public IQueryable<CarRental> GetAllByUserId(int id)
        {
            return context.CarRentals.Where(c => c.UserId == id)
                .Include("Car")
                .Include("Car.Vehicle.Model.Brand")
                .Include("Car.Vehicle.Variant")
                .Include("Car.User")
                .Include("User").OrderBy(c => c.FromDate);
        }

    }
}

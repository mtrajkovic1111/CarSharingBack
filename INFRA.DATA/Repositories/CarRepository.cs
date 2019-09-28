using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class CarRepository : RepositoryBase<Car>, ICarRepository
    {
        public CarRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {

        }
        public IQueryable<Car> GetAllWithRelatedTables()
        {
            return context.Cars
                .Include(m => m.Transmission)
                .Include(m => m.Vehicle)
               // .Include(m => m.Address)
                .Include(m => m.Address.City)
                .Include(c => c.Vehicle.Model.Brand)
                .Include(c => c.Vehicle.Model)
                .Include(c => c.Vehicle.Variant)
                //.Include(c => c.User)
                .Include(c => c.FuelTypes)
                .OrderBy(c => c.PricePerDay);// ??
        }

        //override public Car GetById(int id)
        //{
        //    return context.Cars.Where(c => c.Id == id)
        //        .Include(m => m.Vehicle.Model)
        //        .Include(m => m.Vehicle.Model.Brand)
        //        .Include(m => m.Vehicle.Variant) as Car;
        //}

        public IQueryable<Car> GetAllByIdWithRelatedTables(int Id)
        {
            return context.Cars.Where(c => c.Id == Id)
                //.Include(m => m.Vehicle.Model)
                //.Include(m => m.Vehicle.Model.Brand)
                //.Include(m => m.Vehicle.Variant)
                .Include(m => m.Transmission)
                .Include(m => m.FuelTypes);
        }


        public IQueryable<Car> GetAllCarByBrand(string brand)
        {
            //var cars = context.Cars.Where(c => c.Brand.Name == brand).OrderBy(c => c.PricePerDay);
            //return cars;
            return null;
        }

        public IQueryable<Car> GetAllCarByCity(string city)
        {
            var cars = context.Cars.Where(c => c.Address.City.Name == city).OrderBy(c => c.PricePerDay);
            return cars;
        }

        public IQueryable<Car> GetAllCarByFuel(string fuel)
        {
            return context.Cars.Where(m => m.FuelTypes.Any(f => f.Fuel == fuel));
        }

        public IQueryable<Car> GetAllCarByTransmission(string transmission)
        {
            var cars = context.Cars.Where(c => c.Transmission.Type == transmission).OrderBy(c => c.PricePerDay);
            return cars;
        }

        public IQueryable<Car> GetAllCarByUsername(string username)
        {
            var cars = context.Cars.Where(c => c.User.Username == username).OrderByDescending(c => c.PricePerDay);
            return cars
                .Include(c => c.Vehicle.Model.Brand)
                .Include(c => c.Vehicle.Variant)
                .Include(c => c.Address.City)
                .Include(c => c.Transmission)
                .Include(c => c.FuelTypes);
        }

        public IQueryable<Car> GetAllSearchedCar(int cityId, string startDay, string endDay, int? brandId, int? modelId, int? variantId, int? transmissionId, int? fuelTypeId)
        {

            

            // svi carId koji su rezervisani tad
            var sdate = DateTime.Parse(startDay);
            var edate = DateTime.Parse(endDay);
          //  var rentedCarsId = context.CarRentals.Where(c => SqlFunctions.DatePart("date", c.FromDate) == SqlFunctions.DatePart("date", sdate) && SqlFunctions.DatePart("date", c.TillDate) == SqlFunctions.DatePart("date", edate)).Select(c => c.CarId);

            var rentedCars = context.CarRentals.Where(c => DbFunctions.TruncateTime(c.FromDate).Value <= sdate && DbFunctions.TruncateTime(c.TillDate).Value >= edate ||
                                                           DbFunctions.TruncateTime(c.FromDate).Value <= sdate && sdate <= DbFunctions.TruncateTime(c.TillDate).Value && DbFunctions.TruncateTime(c.TillDate).Value <= edate ||
                                                           DbFunctions.TruncateTime(c.FromDate).Value >= sdate && edate >= DbFunctions.TruncateTime(c.FromDate).Value && DbFunctions.TruncateTime(c.TillDate).Value >= edate ||
                                                           DbFunctions.TruncateTime(c.FromDate).Value >= sdate && DbFunctions.TruncateTime(c.TillDate).Value <= edate);

            var availableCars = context.Cars.Where(m => !rentedCars.Any(p => p.CarId == m.Id));

            var carsSearch = availableCars.Where(c => c.Address.CityId == cityId).OrderByDescending(c => c.PricePerDay);

            if (transmissionId != null && variantId != null) { carsSearch = carsSearch.Where(c => c.Address.CityId == cityId && c.Vehicle.VariantId == variantId && c.TransmissionId == transmissionId).OrderByDescending(c => c.PricePerDay); }
            if (variantId != null) { carsSearch = carsSearch.Where(c => c.Address.CityId == cityId && c.Vehicle.VariantId == variantId).OrderByDescending(c => c.PricePerDay); }
            if (transmissionId != null) { carsSearch = carsSearch.Where(c => c.Address.CityId == cityId && c.TransmissionId == transmissionId).OrderByDescending(c => c.PricePerDay); }


            return carsSearch
                .Include(m => m.Transmission)
                .Include(m => m.Vehicle)
                .Include(m => m.Address)
                .Include(m => m.Address.City)
                .Include(c => c.Vehicle.Model.Brand)
                .Include(c => c.Vehicle.Model)
                .Include(c => c.Vehicle.Variant)
                .Include(c => c.User)
                .Include(c => c.FuelTypes)
                .OrderByDescending(c => c.PricePerDay);// ??

        }

        public int NumberOfUsersCars(int UserId)
        {
            return context.Cars.Where(c => c.UserId == UserId).Count();
        }


    }
}

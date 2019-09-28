using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Interfaces.Repositories
{
    public interface ICarRepository : IRepositoryBase<Car>
    {
        IQueryable<Car> GetAllCarByUsername(string username);
        IQueryable<Car> GetAllCarByCity(string city);
        IQueryable<Car> GetAllCarByBrand(string brand);
        IQueryable<Car> GetAllCarByTransmission(string transmission);
        IQueryable<Car> GetAllCarByFuel(string fuel);
        IQueryable<Car> GetAllSearchedCar(int cityId, string startDate, string endDate, int? brandId, int? modelId, int? variantId, int? transmissionId, int? fuelTypeId);
        int NumberOfUsersCars(int userId);
        IQueryable<Car> GetAllByIdWithRelatedTables(int Id);
        IQueryable<Car> GetAllWithRelatedTables();
    }
}

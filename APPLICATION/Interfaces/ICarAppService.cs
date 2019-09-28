using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.Interfaces
{
    public interface ICarAppService : IAppServiceBase<Car>
    {
        IQueryable<Car> GetAllCarByUsername(string username);
        IQueryable<Car> GetAllCarByCity(string city);
        IQueryable<Car> GetAllCarByBrand(string brand);
        IQueryable<Car> GetAllCarByTransmission(string transmission);
        IQueryable<Car> GetAllCarByFuel(string fuel);
        IQueryable<Car> GetAllSearchedCar(int cityId, string startDate, string endDate, int? brandId, int? modelId, int? variantId, int? transmissionId, int? fuelTypeId);
        int NumberOfUsersCars(int UserId);
        IQueryable<Car> GetAllByIdWithRelatedTables(int Id);
        IQueryable<Car> GetAllWithRelatedTables();
    }
}

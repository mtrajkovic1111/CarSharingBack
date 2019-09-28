using APPLICATION.Interfaces;
using DOMAIN.Entities;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class CarAppService : AppServiceBase<Car>, ICarAppService
    {
        private readonly ICarService _CarService;
        public CarAppService(ICarService carService) : base(carService)
        {
            _CarService = carService;
        }

        public IQueryable<Car> GetAllCarByBrand(string brand)
        {
            return _CarService.GetAllCarByBrand(brand);
        }

        public IQueryable<Car> GetAllCarByCity(string city)
        {
            return _CarService.GetAllCarByCity(city);
        }

        public IQueryable<Car> GetAllCarByFuel(string fuel)
        {
            return _CarService.GetAllCarByFuel(fuel);
        }

        public IQueryable<Car> GetAllCarByTransmission(string transmission)
        {
            return _CarService.GetAllCarByTransmission(transmission);
        }

        public IQueryable<Car> GetAllCarByUsername(string username)
        {
            return _CarService.GetAllCarByUsername(username);
        }

        public IQueryable<Car> GetAllSearchedCar(int cityId, string startDate, string endDate, int? brandId, int? modelId, int? variantId, int? transmissionId, int? fuelTypeId)
        {
            return _CarService.GetAllSearchedCar(cityId, startDate, endDate, brandId, modelId, variantId, transmissionId, fuelTypeId);
        }

        public int NumberOfUsersCars(int UserId)
        {
            return _CarService.NumberOfUsersCars(UserId);
        }

        public IQueryable<Car> GetAllByIdWithRelatedTables(int Id)
        {
            return _CarService.GetAllByIdWithRelatedTables(Id);
        }

        public IQueryable<Car> GetAllWithRelatedTables()
        {
            return _CarService.GetAllWithRelatedTables();
        }

    }
}

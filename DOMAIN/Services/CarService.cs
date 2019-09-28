using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Services
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository) : 
            base(carRepository)
        {
            _carRepository = carRepository;
        }

        public IQueryable<Car> GetAllCarByBrand(string brand)
        {
            return _carRepository.GetAllCarByBrand(brand);
        }

        public IQueryable<Car> GetAllCarByCity(string city)
        {
            return _carRepository.GetAllCarByCity(city);
        }

        public IQueryable<Car> GetAllCarByFuel(string fuel)
        {
            return _carRepository.GetAllCarByFuel(fuel);
        }

        public IQueryable<Car> GetAllCarByTransmission(string transmission)
        {
            return _carRepository.GetAllCarByTransmission(transmission);
        }

        public IQueryable<Car> GetAllCarByUsername(string username)
        {
            return _carRepository.GetAllCarByUsername(username);
        }

        public IQueryable<Car> GetAllSearchedCar(int cityId, string startDate, string endDate, int? brandId, int? modelId, int? variantId, int? transmissionId, int? fuelTypeId)
        {
            return _carRepository.GetAllSearchedCar(cityId, startDate, endDate, brandId, modelId, variantId, transmissionId, fuelTypeId);
        }

        public int NumberOfUsersCars(int UserId)
        {
            return _carRepository.NumberOfUsersCars(UserId);
        }

        public IQueryable<Car> GetAllByIdWithRelatedTables(int Id)
        {
            return _carRepository.GetAllByIdWithRelatedTables(Id);
        }

        public IQueryable<Car> GetAllWithRelatedTables()
        {
            return _carRepository.GetAllWithRelatedTables();
        }

    }
}

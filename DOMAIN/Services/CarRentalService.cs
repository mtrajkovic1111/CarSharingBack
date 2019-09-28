using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN.Services
{
    public class CarRentalService : ServiceBase<CarRental>, ICarRentalService
    {
        private readonly ICarRentalRepository _carRentalRepository;
        public CarRentalService(ICarRentalRepository carRentalRepository) : base(carRentalRepository)
        {
            _carRentalRepository = carRentalRepository;
        }

        public IQueryable<CarRental> GetAllWithRelatedTables()
        {
            return _carRentalRepository.GetAllWithRelatedTables();
        }

        public IQueryable<CarRental> GetAllByIdWithRelatedTables(int id)
        {
            return _carRentalRepository.GetAllByIdWithRelatedTables(id);
        }

        public IQueryable<CarRental> GetAllByUserId(int id)
        {
            return _carRentalRepository.GetAllByUserId(id);
        }
    }
}

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
    public class CarRentalAppService : AppServiceBase<CarRental>, ICarRentalAppService
    {
        private readonly ICarRentalService _CarRentalService;
        public CarRentalAppService(ICarRentalService carRentalService) : base(carRentalService)
        {
            _CarRentalService = carRentalService;
        }

        public IQueryable<CarRental> GetAllWithRelatedTables()
        {
            return _CarRentalService.GetAllWithRelatedTables();
        }

        public IQueryable<CarRental> GetAllByIdWithRelatedTables(int id)
        {
            return _CarRentalService.GetAllByIdWithRelatedTables(id);
        }

        public IQueryable<CarRental> GetAllByUserId(int id)
        {
            return _CarRentalService.GetAllByUserId(id);
        }
    }
}

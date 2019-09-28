using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Services
{
    public class FuelTypeService : ServiceBase<FuelType>, IFuelTypeService
    {
        private readonly IFuelTypeRepository _fueltypeRepository;
        public FuelTypeService(IFuelTypeRepository fueltypeRepository) : base(fueltypeRepository)
        {
            _fueltypeRepository = fueltypeRepository;
        }
    }
}

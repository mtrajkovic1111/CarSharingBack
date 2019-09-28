using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Services
{
    public class TransmissionService : ServiceBase<Transmission>, ITransmissionService
    {
        private readonly ITransmissionRepository _transmissionRepository;
        public TransmissionService(ITransmissionRepository transmissionRepository) : base(transmissionRepository)
        {
            _transmissionRepository = transmissionRepository;
        }
    }
}

﻿using APPLICATION.Interfaces;
using DOMAIN.Entities;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class TransmissionAppService : AppServiceBase<Transmission>, ITransmissionAppService
    {
        private readonly ITransmissionService _TransmissionService;
        public TransmissionAppService(ITransmissionService transmissionService) : base(transmissionService)
        {
            _TransmissionService = transmissionService;
        }
    }
}

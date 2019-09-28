using APPLICATION.Interfaces;
using AutoMapper;
using CarSharingWebAPI.DTOS;
using DOMAIN.Entities;
using INFRA.DATA;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarSharingWebAPI.Controllers
{
    public class TransmissionsController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private ITransmissionAppService _transmissionsAppService;

        public TransmissionsController(IUnitOfWork<Context> uow, ITransmissionAppService transmissionsAppService )
        {
            _uow = uow;
            _transmissionsAppService = transmissionsAppService;
        }

        [AllowAnonymous]
        public IHttpActionResult GetAll()
        {
            var t = _transmissionsAppService.GetAll();
            var tDTO = Mapper.Map<IEnumerable<Transmission>, IEnumerable<TransmissionDTO>>(t);
            return Ok(tDTO);
        }
    }
}

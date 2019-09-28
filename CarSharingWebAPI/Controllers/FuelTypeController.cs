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
    public class FuelTypeController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private IFuelTypeAppService _fuelTypeAppService;

        public FuelTypeController(IUnitOfWork<Context> uow, IFuelTypeAppService fuelTypeAppService)
        {
            _uow = uow;
            _fuelTypeAppService = fuelTypeAppService;

        }
        [AllowAnonymous]
        public IHttpActionResult GetAll()
        {
            var fType = _fuelTypeAppService.GetAll();
            var fTypeDTO = Mapper.Map<IEnumerable<FuelType>, IEnumerable<FuelTypeDTO>>(fType);
            return Ok(fTypeDTO);
        }


    }
}

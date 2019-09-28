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
    public class VehicleController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private IVehicleAppService _vehicleAppService;

        public VehicleController(IUnitOfWork<Context> uow, IVehicleAppService vehicleAppService)
        {
            _uow = uow;
            _vehicleAppService = vehicleAppService;
        }

        [AllowAnonymous]
        public IHttpActionResult GetVehicleId(int modelId, int variantId)
        {
            var vId = _vehicleAppService.GetVehicleId(modelId, variantId);
            var vIdDTO = Mapper.Map<IEnumerable<Vehicle>, IEnumerable<VehicleDTO>>(vId);
            return Ok(vIdDTO);
        }

        [AllowAnonymous]
        [Route("api/vehicle/modelvar")]
        public IHttpActionResult GetVehicleModelVariant(int vehicleId)
        {
            var vehicle = _vehicleAppService.GetModelVariantByVehicleId(vehicleId);
            var vehicleDTO = Mapper.Map<IEnumerable<Vehicle>, IEnumerable<VehicleDTO>>(vehicle);
            return Ok(vehicleDTO);
        }

        [AllowAnonymous]
        [Route("api/vehicle/string")]
        public IHttpActionResult GetBrandModelVariantByVehicleId(int vehicleId)
        {
            var vehicle = _vehicleAppService.GetBrandModelVariantByVehicleID(vehicleId);
            return Ok(vehicle);
        }


    }
}

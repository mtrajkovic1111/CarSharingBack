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
    public class CityController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private ICityAppService _cityAppService;

        public CityController(IUnitOfWork<Context> uow, ICityAppService cityAppService)
        {
            _uow = uow;
            _cityAppService = cityAppService;
        }

        [AllowAnonymous]
        public IHttpActionResult GetAll()
            {
            var cities = _cityAppService.GetAll();
            var citiesDTO = Mapper.Map<IEnumerable<City>, IEnumerable<CityDTO>>(cities);
            return Ok(citiesDTO);
        }

       
    }
}

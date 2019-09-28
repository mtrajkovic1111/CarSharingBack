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
    [AllowAnonymous]
    public class BrandsController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private IBrandAppService _brandAppService;

        public BrandsController(IUnitOfWork<Context> uow, IBrandAppService brandAppService)
        {
            _uow = uow;
            _brandAppService = brandAppService;
        }
        [AllowAnonymous]
        public IHttpActionResult GetAllBrands()
        {
            var brands = _brandAppService.GetAll();
            var brandsDTO = Mapper.Map<IEnumerable<Brand>, IEnumerable<BrandDTO>>(brands);
            return Ok(brandsDTO);
        }
    }


}

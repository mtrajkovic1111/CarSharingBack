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
    public class ModelsController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private IModelAppService _modelAppService;

        public ModelsController(IUnitOfWork<Context> uow, IModelAppService modelAppService)
        {
            _uow = uow;
            _modelAppService = modelAppService;
        }
        [AllowAnonymous]
        public IHttpActionResult GetAllModelsByBrand(string brand)
        {
            var models = _modelAppService.GetAllModelsForBrand(brand);
            var modelDTO = Mapper.Map<IEnumerable<Model>, IEnumerable<ModelDTO>>(models);
            return Ok(modelDTO);
        }

        [AllowAnonymous]
        public IHttpActionResult GetModelsForBrand(int brandId)
        {
            var models = _modelAppService.GetModelsForBrand(brandId);
            var modelDTO = Mapper.Map<IEnumerable<Model>, IEnumerable<ModelDTO>>(models);
            return Ok(modelDTO);
        }
    }
}

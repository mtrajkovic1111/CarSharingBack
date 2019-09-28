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
using System.Threading;
using System.Web.Http;


namespace CarSharingWebAPI.Controllers
{
  // [Authorize]
    public class VariantsController : ApiController
    {
        private IVariantAppService _varService;
        private IUnitOfWork<Context> _uow;

        public VariantsController(IVariantAppService varService, IUnitOfWork<Context> uow)
        {
            _varService = varService;
            _uow = uow;
        }

        [AllowAnonymous]
        public IHttpActionResult GetVariants()
        {
            var variants = _varService.GetAll();
            var variantsDTO = (Mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDTO>>(variants));
            return Ok(variantsDTO);

        }

        [AllowAnonymous]
        public IHttpActionResult GetVariantsOfModel(string model)
        {
            var varsOfModel = _varService.GetVariantsOfModel(model);
            var varsOfModelDTO = Mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDTO>>(varsOfModel);
            return Ok(varsOfModelDTO);
        }

        [AllowAnonymous]
        public IHttpActionResult GetModelVariants(int modelId)
        {
            var varsOfModel = _varService.GetModelVariants(modelId);
            var varsOfModelDTO = Mapper.Map<IEnumerable<Variant>, IEnumerable<VariantDTO>>(varsOfModel);
            return Ok(varsOfModelDTO);
        }

        //public IHttpActionResult GetVariant(int id)
        //{
        //    var varinatById = _varService.GetById(id);

        //    if (varinatById == null)
        //        //throw new HttpResponseException(HttpStatusCode.NotFound);
        //        return NotFound();

        //        return Ok(Mapper.Map<Variant, VariantDTO>(varinatById));
        //}

        [HttpPost]
        public IHttpActionResult CreateVariant(VariantDTO variantDto)
        {
            if (!ModelState.IsValid)
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();

           var variant = Mapper.Map<VariantDTO, Variant>(variantDto);

            _varService.Add(variant);
            _uow.Save();

            variantDto.Id = variant.Id;

            //return variantDto; instead we are returning URI*(unified resource identifier)
            return Created(new Uri(Request.RequestUri + "/" + variant.Id), variantDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateVariant(int id, VariantDTO variantDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var variantFromDb = _varService.GetById(id);

            if (variantFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            //Mapper.Map<VariantDTO, Variant>(variantDTO, variantFromDb);    
            Mapper.Map(variantDTO, variantFromDb);
            _uow.Save();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteVariant(int id)
        {
            var variantFromDb = _varService.GetById(id);
            if (variantFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<Variant, VariantDTO>(variantFromDb);

            _varService.Remove(variantFromDb);
            _uow.Save();
            return Ok();


        }

    }
}

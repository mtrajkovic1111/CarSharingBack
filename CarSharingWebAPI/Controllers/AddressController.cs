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
    public class AddressController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private IAddressAppService _addressAppService;

        public AddressController(IUnitOfWork<Context> uow, IAddressAppService addressAppService)
        {
            _uow = uow;
            _addressAppService = addressAppService;
        }
        [AllowAnonymous]
        [HttpPost]
        public IHttpActionResult AddAddress(AddressDTO addressDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var address = Mapper.Map<AddressDTO, Address>(addressDto);
            _addressAppService.Add(address);
            _uow.Save();

            addressDto.Id = address.Id;
            return Created(new Uri(Request.RequestUri + "/" + address.Id), addressDto);

        }
    }
}

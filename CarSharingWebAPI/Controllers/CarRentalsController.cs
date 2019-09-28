using APPLICATION.AppServices;
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
    public class CarRentalsController : ApiController
    {
        private CarRentalAppService _carRentalAppService;
        private IUnitOfWork<Context> _uow;
        private CarAppService _carAppService;

        public CarRentalsController(CarRentalAppService carRentalAppService, IUnitOfWork<Context> uow, CarAppService carAppService)
        {
            _carRentalAppService = carRentalAppService;
            _uow = uow;
            _carAppService = carAppService;
        }

     
        [Route("api/carrentals")]
        [HttpGet]
        public IHttpActionResult GetAllWithRelatedTables()
        {
            var rentedCars = _carRentalAppService.GetAllWithRelatedTables();
            return Ok(rentedCars);
        }

        [AllowAnonymous]
        [Route("api/carrental/userid")]
        [HttpGet]
        public IHttpActionResult GetAllByUserId(int id)
        {
            var rentedCar = _carRentalAppService.GetAllByUserId(id).ToList();
            return Ok(rentedCar);
        }

        [AllowAnonymous]
        [Route("api/carrental")]
        [HttpGet]
        public IHttpActionResult GetAllById(int id)
        {
            var rentedCar = _carRentalAppService.GetAllByIdWithRelatedTables(id).FirstOrDefault();
            return Ok(rentedCar);
        }


        [HttpPost]
        [Route("api/carrentals")]
        public IHttpActionResult AddCarRental(CarRentalDTO carRentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var carRental = Mapper.Map<CarRentalDTO, CarRental>(carRentalDto);

            _carRentalAppService.Add(carRental);
            _uow.Save();    


            carRentalDto.Id = carRental.Id;
            return Created(new Uri(Request.RequestUri + "/" + carRental.Id), carRentalDto);

        }

        [HttpPut]
        [Route("api/carrentals")]
        public IHttpActionResult UpdateCarRentalPrice(int id, CarRentalDTO carRentalDto)
        {
            var rentalFromDb = _carRentalAppService.GetById(id);
            if (rentalFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            rentalFromDb.TotalPricePerDay = carRentalDto.TotalPricePerDay;
            rentalFromDb.RentedWithEnsurance = carRentalDto.RentedWithEnsurance;
            rentalFromDb.RentedWithNavigation = carRentalDto.RentedWithNavigation;

            _uow.Save();
            return Ok();

        }

        [HttpDelete]
        public IHttpActionResult DeleteRentedCar(int id)
        {
            var carRentalFromDb = _carRentalAppService.GetById(id);
            if (carRentalFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<CarRental, CarRentalDTO>(carRentalFromDb);

            _carRentalAppService.Remove(carRentalFromDb);
            _uow.Save();
            return Ok();


        }


    }
}



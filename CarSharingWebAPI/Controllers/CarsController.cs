using APPLICATION.AppServices;
using APPLICATION.Interfaces;
using AutoMapper;
using CarSharingWebAPI.DTOS;
using DOMAIN.Entities;
using INFRA.DATA;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CarSharingWebAPI.Controllers
{
    public class CarsController : ApiController
    {
        private IUnitOfWork<Context> _uow;
        private ICarAppService _carService;
        private IFuelTypeAppService _fuelTypeService;

        public CarsController(IUnitOfWork<Context> uow, ICarAppService carService, IFuelTypeAppService fuelTypeService)
        {
            _uow = uow;
            _carService = carService;
            _fuelTypeService = fuelTypeService;
        }

     

        [AllowAnonymous]
        public IHttpActionResult GetAll()
        {
            var cars = _carService.GetAll().Count();

            return Ok(cars);
        }

        [AllowAnonymous]
        [Route("api/cars/allbyid")]
        public IHttpActionResult GetAllByIdWithRelatedTables(int Id)
        {
            var cars = _carService.GetAllByIdWithRelatedTables(Id).FirstOrDefault();

            return Ok(cars);
        }


        [AllowAnonymous]
        public IHttpActionResult GetById(int Id)
        {
            var cars = _carService.GetById(Id);

            return Ok(cars);
        }


        [AllowAnonymous]
        [Route("api/cars/all")]
        public IHttpActionResult GetAllWithRelatedTables()
        {
            var cars = _carService.GetAllWithRelatedTables().ToList();
            
            return Ok(cars);
        }

        
        [Route("api/cars/countcars")]
        public IHttpActionResult GetNumberOfUsersCar(int id)
        {
            var numOfCars = _carService.NumberOfUsersCars(id);
            return Ok(numOfCars);
        }

        public IHttpActionResult GetAllCarByBrand(string brand)
        {
            var brandCars = _carService.GetAllCarByBrand(brand);
            return Ok(Mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(brandCars));
        }

        public IHttpActionResult GetAllCarByCity(string city)
        {
            var cityCars = _carService.GetAllCarByCity(city);
            return Ok(Mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(cityCars));
        }

        [AllowAnonymous]
        [Route("api/cars/username")]
        public IHttpActionResult GetAllCarByUsername(string username)
        {
            var userCars = _carService.GetAllCarByUsername(username).ToList();

            //var usersCarsDto = Mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(userCars);

            return Ok(userCars);
        }

       // [AllowAnonymous]
        [HttpPost]
        public IHttpActionResult AddCar(CarDTO carDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var addressDTO = carDto.AddressDTO;
            var address = Mapper.Map<AddressDTO, Address>(addressDTO);

            var fuelTypeDTO = carDto.FuelTypesDTO;
            var fuelTypes = Mapper.Map<ICollection<FuelTypeDTO>, ICollection<FuelType>>(fuelTypeDTO);

            var car = Mapper.Map<CarDTO, Car>(carDto);
            car.FuelTypes = new List<FuelType>();

            foreach (var ft in fuelTypes)
            {
                var fuelType = _fuelTypeService.GetById(ft.Id);
                if (fuelType != null)
                    car.FuelTypes.Add(fuelType);
                else
                    car.FuelTypes.Add(ft);
            }

            
            car.Address = address;
            _carService.Add(car);
            _uow.Save();

            carDto.Id = car.Id;
            return Created(new Uri(Request.RequestUri + "/" + car.Id), carDto);

        }

       // [AllowAnonymous]
        [HttpPut]
        public IHttpActionResult UpdateCar(int id, CarDTO carDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var carFromDb = _carService.GetById(id);

            if (carFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            carFromDb.HasAirCondition = carDTO.HasAirCondition;
            carFromDb.HasEnsurance = carDTO.HasEnsurance;
            carFromDb.HasNavigation = carDTO.HasNavigation;
            carFromDb.IsAvailable = true;
            carFromDb.PricePerDay = carDTO.PricePerDay;
            carFromDb.NavigationPrice = carDTO.NavigationPrice;
            carFromDb.EnsurancePrice = carDTO.EnsurancePrice;

            _uow.Save();
            return Ok();
        }

        [AllowAnonymous]
        [Route("api/cars/search")]
        public IHttpActionResult GetSearchedCars(int cityId, string startDate,string endDate, int? brandId, int? modelId, int? variantId, int? transmissionId, int? fuelTypeId)
        {

            var searchedCars = _carService.GetAllSearchedCar(cityId, startDate, endDate, brandId, modelId, variantId, transmissionId, fuelTypeId).ToList();
            //var usersCarsDto = Mapper.Map<IEnumerable<Car>, IEnumerable<CarDTO>>(searchedCars);

            return Ok(searchedCars);
        }
       // [AllowAnonymous]
        [HttpDelete]
        public IHttpActionResult DeleteCars(int id)
        {
            var carFromDb = _carService.GetById(id);
            if (carFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<Car, CarDTO>(carFromDb);

            _carService.Remove(carFromDb);
            _uow.Save();
            return Ok();


        }

        [HttpPut]
        [Route("api/cars/addcarpic")]
        public IHttpActionResult AddCarPicture(int id)
        {

            var carFromDb = _carService.GetById(id);
            if (carFromDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var httpRequest = HttpContext.Current.Request;

            var postedFile = httpRequest.Files["uploadedFile"];

            using (var reader = new BinaryReader(postedFile.InputStream))
            {
                carFromDb.CarPicture = reader.ReadBytes(postedFile.ContentLength);
            }

            _uow.Save();
            return Ok();

        }



    }
}

using AutoMapper;
using CarSharingWebAPI.DTOS;
using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharingWebAPI.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Variant, VariantDTO>();
            Mapper.CreateMap<VariantDTO, Variant>();

            Mapper.CreateMap<User, UserDTO>();
            Mapper.CreateMap<UserDTO, User>();

            Mapper.CreateMap<Transmission, TransmissionDTO>();
            Mapper.CreateMap<TransmissionDTO, Transmission>();

            Mapper.CreateMap<Model, ModelDTO>();
            Mapper.CreateMap<ModelDTO, Model>();

            Mapper.CreateMap<FuelType, FuelTypeDTO>();
            Mapper.CreateMap<FuelTypeDTO, FuelType>();

            Mapper.CreateMap<City, CityDTO>();
            Mapper.CreateMap<CityDTO, City>();

            Mapper.CreateMap<CarRental, CarRentalDTO>();
            Mapper.CreateMap<CarRentalDTO, CarRental>();

            Mapper.CreateMap<Car, CarDTO>();
            Mapper.CreateMap<CarDTO, Car>();

            Mapper.CreateMap<Brand, BrandDTO>();
            Mapper.CreateMap<BrandDTO, Brand>();

            Mapper.CreateMap<Address, AddressDTO>();
            Mapper.CreateMap<AddressDTO, Address>();

            Mapper.CreateMap<Vehicle, VehicleDTO>();
            Mapper.CreateMap<VehicleDTO, Vehicle>();
        }
    }
}
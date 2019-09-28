using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOMAIN.Services
{
    public class AddressService : ServiceBase<Address>, IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        public AddressService(IAddressRepository addressRepository) : base(addressRepository)
        {
            _addressRepository = addressRepository;
        }


    }
}

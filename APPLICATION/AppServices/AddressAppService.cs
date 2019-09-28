using APPLICATION.Interfaces;
using DOMAIN.Entities;
using DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{
    public class AddressAppService : AppServiceBase<Address>, IAddressAppService
    {
        private readonly IAddressService _AddressService;
        public AddressAppService(IAddressService addressService) : base(addressService)
        {
            _AddressService = addressService;
        }
    }
}

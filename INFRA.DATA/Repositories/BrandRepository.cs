using DOMAIN.Entities;
using DOMAIN.Interfaces.Repositories;
using INFRA.DATA.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.Repositories
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(IUnitOfWork<Context> unitOfWork) : base(unitOfWork)
        {
        }
    }
}

﻿using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.Interfaces
{
    public interface IVariantAppService : IAppServiceBase<Variant>
    {
        IQueryable<Variant> GetVariantsOfModel(string model);
        IQueryable<Variant> GetModelVariants(int modelId);
    }
}

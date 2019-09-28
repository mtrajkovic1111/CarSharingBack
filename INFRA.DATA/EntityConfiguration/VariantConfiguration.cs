using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    class VariantConfiguration : EntityTypeConfiguration<Variant>
    {
        public VariantConfiguration()
        {
            HasMany(v => v.Vehicles)
                .WithRequired(v => v.Variant);
        }
    }
}

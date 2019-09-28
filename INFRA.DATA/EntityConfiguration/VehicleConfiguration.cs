using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class VehicleConfiguration : EntityTypeConfiguration<Vehicle>
    {
        public VehicleConfiguration()
        {

            HasMany(v => v.Cars)
                 .WithRequired(c => c.Vehicle);

            HasRequired(v => v.Model)
                .WithMany(m => m.Vehicles)
                .HasForeignKey(v => v.ModelId);

            HasRequired(v => v.Variant)
                .WithMany(v => v.Vehicles)
                .HasForeignKey(v => v.VariantId);
              

        }
    }
}

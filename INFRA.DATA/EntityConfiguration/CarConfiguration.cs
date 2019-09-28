using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            // ToTable("name");
            // HasKey(c => c.id);

            HasRequired(c => c.Address)
            .WithMany(c => c.Cars)
            .HasForeignKey(c => c.AddressId);

           HasRequired(c => c.Vehicle)
            .WithMany(v => v.Cars)
            .HasForeignKey(c => c.VehicleId);

            HasMany(c => c.FuelTypes)
            .WithMany(f => f.Cars)
            .Map(m => m.ToTable("FuelTypeCars"));

            HasRequired(c => c.Transmission)
            .WithMany(g => g.Cars)
            .HasForeignKey(c => c.TransmissionId);

            HasRequired(c => c.User)
            .WithMany(a => a.Cars)
            .HasForeignKey(c => c.UserId);
        }

    }
  
}

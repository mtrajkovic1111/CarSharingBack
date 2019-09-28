using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class CarRentalsConfiguration : EntityTypeConfiguration<CarRental>
    {
        public CarRentalsConfiguration()
        {
            HasKey(c => c.Id);

            HasRequired(c => c.Car)
            .WithMany(m => m.CarRentals)
            .HasForeignKey(c => c.CarId)
            .WillCascadeOnDelete(false);



            HasRequired(c => c.User)
                .WithMany(u => u.CarRentals)
                .HasForeignKey(c => c.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}

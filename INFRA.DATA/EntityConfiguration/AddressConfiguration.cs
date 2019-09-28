using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class AddressConfiguration: EntityTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(a => a.Street)
                .IsRequired();
            Property(a => a.Number)
                .IsRequired();

            HasRequired(a => a.City)
                .WithMany(c => c.Addresses)
                .HasForeignKey(a => a.CityId);

        }
    }
}

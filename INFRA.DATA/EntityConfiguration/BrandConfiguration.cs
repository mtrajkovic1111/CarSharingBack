using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class BrandConfiguration: EntityTypeConfiguration<Brand>
    {
        public BrandConfiguration()
        {
            Property(b => b.Name)
                .IsRequired();

                    
        }
    }
}

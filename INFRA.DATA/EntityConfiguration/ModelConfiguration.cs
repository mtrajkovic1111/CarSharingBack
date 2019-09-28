using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class ModelConfiguration : EntityTypeConfiguration<Model>
    {
        public ModelConfiguration()
        {
            Property(m => m.ModelType)
                .IsRequired();

            HasMany(m => m.Vehicles)
                 .WithRequired(v => v.Model);
            
        }
    }
}

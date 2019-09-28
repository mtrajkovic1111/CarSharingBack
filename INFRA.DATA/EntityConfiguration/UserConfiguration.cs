using DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA.EntityConfiguration
{
    public class UserConfiguration: EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(u => u.Name)
                .IsRequired();
            Property(u => u.Surname)
                .IsRequired();
            Property(u => u.Username)
                .IsRequired();
            //Property(u => u.Password)
            //    .IsRequired();
            Property(u => u.Email)
                .IsRequired();
            Property(u => u.Rate)
                .IsOptional();
        }
    }
}

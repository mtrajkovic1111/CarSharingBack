using DOMAIN.Entities;
using INFRA.DATA.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRA.DATA
{
    public class Context: DbContext
    {
        public Context()
            : base("name=SConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Variant> Variants { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CarRental> CarRentals { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new BrandConfiguration());
            modelBuilder.Configurations.Add(new CarRentalsConfiguration());
            modelBuilder.Configurations.Add(new ModelConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new VariantConfiguration());
            modelBuilder.Configurations.Add(new VehicleConfiguration());

        }
    }

}

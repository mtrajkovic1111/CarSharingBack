[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CarSharingWebAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CarSharingWebAPI.App_Start.NinjectWebCommon), "Stop")]

namespace CarSharingWebAPI.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using APPLICATION.AppServices;
    using APPLICATION.Interfaces;
    using DOMAIN.Interfaces.Repositories;
    using DOMAIN.Interfaces.Services;
    using DOMAIN.Services;
    using INFRA.DATA;
    using INFRA.DATA.Repositories;
    using INFRA.DATA.UOW;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Ninject.Web.WebApi;
    using Quartz;
    using Quartz.Impl;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        /// 

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();


                RegisterServices(kernel);
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);//
                kernel.Bind<IScheduler>().ToMethod(x =>
                {
                    var scheduler = StdSchedulerFactory.GetDefaultScheduler();
                    scheduler.JobFactory = new JobFactory(kernel);
                    return scheduler;
                });

                var sch = kernel.Get<IScheduler>(); 
                IJobDetail job = JobBuilder.Create<CheckCalendarJob>().Build();
                var trigger = TriggerBuilder.Create()
                    .WithCronSchedule("0 0 0 * * ?")
                    .ForJob(job)
                    .Build();
                sch.ScheduleJob(job, trigger);
                sch.Start();

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }



        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>)).InRequestScope(); //??
            kernel.Bind<IAddressAppService>().To<AddressAppService>().InRequestScope();
            kernel.Bind<IBrandAppService>().To<BrandAppService>().InRequestScope();
            kernel.Bind<ICarAppService>().To<CarAppService>().InRequestScope();
            kernel.Bind<ICarRentalAppService>().To<CarRentalAppService>().InRequestScope();
            kernel.Bind<ICityAppService>().To<CityAppService>().InRequestScope();
            // kernel.Bind<ILogInAppService>().To<LogInAppService>().InRequestScope();
            // kernel.Bind<IBasicAuthenticationAppService>().To<BasicAuthenticationAppService>().InRequestScope();
            kernel.Bind<IFuelTypeAppService>().To<FuelTypeAppService>().InRequestScope();
            kernel.Bind<IModelAppService>().To<ModelAppService>().InRequestScope();
            kernel.Bind<ITransmissionAppService>().To<TransmissionAppService>().InRequestScope();
            kernel.Bind<IUserAppService>().To<UserAppService>().InRequestScope();
            kernel.Bind<IVariantAppService>().To<VariantAppService>().InRequestScope();
            kernel.Bind<IVehicleAppService>().To<VehicleAppService>().InRequestScope();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>)).InRequestScope();
            kernel.Bind<IAddressService>().To<AddressService>().InRequestScope();
            kernel.Bind<IBrandService>().To<BrandService>().InRequestScope();
            kernel.Bind<ICarService>().To<CarService>().InRequestScope();
            kernel.Bind<ICarRentalService>().To<CarRentalService>().InRequestScope();
            kernel.Bind<ICityService>().To<CityService>().InRequestScope();
            kernel.Bind<IVehicleService>().To<VehicleService>().InRequestScope();
            kernel.Bind<IFuelTypeService>().To<FuelTypeService>().InRequestScope();
            kernel.Bind<IModelService>().To<ModelService>().InRequestScope();
            kernel.Bind<ITransmissionService>().To<TransmissionService>().InRequestScope();
            kernel.Bind<IUserService>().To<UserService>().InRequestScope();
            kernel.Bind<IVariantService>().To<VariantService>().InRequestScope();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>)).InRequestScope();
            kernel.Bind<IAddressRepository>().To<AddressRepository>().InRequestScope();
            kernel.Bind<IBrandRepository>().To<BrandRepository>().InRequestScope();
            kernel.Bind<ICarRepository>().To<CarRepository>().InRequestScope();
            kernel.Bind<ICarRentalRepository>().To<CarRentalRepository>().InRequestScope();
            kernel.Bind<ICityRepository>().To<CityRepository>().InRequestScope();
            kernel.Bind<IFuelTypeRepository>().To<FuelTypeRepository>().InRequestScope();
            kernel.Bind<IModelRepository>().To<ModelRepository>().InRequestScope();
            kernel.Bind<ITransmissionRepository>().To<TransmissionRepository>().InRequestScope();
            kernel.Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            kernel.Bind<IVariantRepository>().To<VariantRepository>().InRequestScope();
            kernel.Bind<IVehicleRepository>().To<VehicleRepository>().InRequestScope();

            // kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            kernel.Bind(typeof(IUnitOfWork<>)).To(typeof(UnitOfWork<>)).InRequestScope();
        }
    }
}

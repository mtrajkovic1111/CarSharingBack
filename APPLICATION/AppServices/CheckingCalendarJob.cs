using DOMAIN.Interfaces.Services;
using INFRA.DATA;
using INFRA.DATA.UOW;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPLICATION.AppServices
{


    public class CheckCalendarJob : IJob
    {
        private readonly ICarRentalService _CarRentalService;
        private readonly ICarService _CarService;
        private readonly IUnitOfWork<Context> _uow;

        public CheckCalendarJob(ICarRentalService CarRentalService, ICarService CarService, IUnitOfWork<Context> uow)
        {
            _CarRentalService = CarRentalService;
            _CarService = CarService;
            _uow = uow;

        }

        public void Execute(IJobExecutionContext context)
        {
            var carRentals = _CarRentalService.GetAll();
            foreach (var carRental in carRentals)
            {
                var carId = carRental.CarId;
                var car = _CarService.GetById(carId);
                DateTime date1 = DateTime.Now.Date;

                if (carRental.FromDate.Date == DateTime.Now.Date)
                {
                    car.IsAvailable = false;
                    _uow.Save();
                }

                if (carRental.TillDate.Date == DateTime.Now.Date)
                {
                    car.IsAvailable = true;
                    _uow.Save();
                }
            }
        }


    }


}


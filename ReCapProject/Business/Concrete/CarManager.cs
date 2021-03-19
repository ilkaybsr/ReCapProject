using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Business
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.Name.Length>=2 && car.DailyPrice >0 )
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Ürün Eklenemedi!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id);
        }

        public List<Car> GetByDailyPrice()
        {
            return _carDal.GetAll(p => p.DailyPrice>0);
        }

        public List<Car> GetById(int carID)
        {
            return _carDal.GetById(carID);
           
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}

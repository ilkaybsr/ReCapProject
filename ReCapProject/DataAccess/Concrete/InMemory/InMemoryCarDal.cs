using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{Id=1, BrandId=1, ColorId=12, ModelYear="2021", DailyPrice=6000, Description="Hasarsız" },
                new Car{Id=2, BrandId=1, ColorId=11, ModelYear="2010", DailyPrice=600, Description="Dizel" },
                new Car{Id=3, BrandId=2, ColorId=8, ModelYear="2018", DailyPrice=1000, Description="Manuel" },
                new Car{Id=4, BrandId=2, ColorId=4, ModelYear="2020", DailyPrice=4000, Description="Hasarlı" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Aracınız eklendi. ");
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.FirstOrDefault(x => x.Id == car.Id);
            _cars.Remove(carToDelete);
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carID)
        { 
            var car = _cars.SingleOrDefault(c=> c.Id == carID);
            return _cars; 
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

            
        }
    }
}

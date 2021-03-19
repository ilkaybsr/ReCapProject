using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business
{
    public interface ICarService
    {
        public void Add(Car car);

        public void Update(Car car);

        public void Delete(Car car);

        public List<Car> GetAll();

        public List<Car> GetById(int carID);

        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetByDailyPrice();
        List<CarDetailDto> GetCarDetails()


    }
}

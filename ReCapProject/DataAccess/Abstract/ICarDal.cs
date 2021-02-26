using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        public void Add(Car car);

        public void Update(Car car);

        public void Delete(Car car);

        public List<Car> GetAll();

        public List<Car> GetById(int carID);
    }
}

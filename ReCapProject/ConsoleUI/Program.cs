using Business;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var userService = new UserManager(new EfUserDal());
            var customerService = new CustomerManager(new EfCustomerDal()) ;

            var user = userService.GetAll()[0];

            customerService.Add(new Customer
            {
                UserId = user.Id,
                CompanyName = "Test Company"
            });
            
            CarTest();

            //BrandTest();

            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.DailyPrice + "/" + car.BrandName + "/" + car.ColorName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}


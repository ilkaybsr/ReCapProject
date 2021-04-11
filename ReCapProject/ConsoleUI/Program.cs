using Business;
using Business.Concrete;
using Business.Constants;
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
            UserTest();
            CustomerTest();
            CarTest();


            //BrandTest();

            //ColorTest();

        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "İlkay", LastName = "Aydın", Email = "ilkaybsr@gmail.com", Password = "123" });
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id = 1, UserId =1, CompanyName = "Scrape.do "});
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
                RentalManager rentalManager = new RentalManager(new EfRentalDal());
                var rentResult = rentalManager.Add(new Rental() { CarId = 1, CustomerId = 1, RentDate = DateTime.Now });
                Console.WriteLine(Messages.CarRented);
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}


using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from a in context.Cars
                             join b in context.Brands
                             on a.BrandId equals b.BrandId
                             select new CarDetailDto {CarName = a.Name, BrandName =b.BrandName, DailyPrice =a.DailyPrice};
                return result.ToList();

                var result2 = from a in context.Cars
                              join c in context.Colors
                              on a.ColorId equals c.ColorId
                              select new CarDetailDto
                              {
                                  ColorName = c.ColorName
                              };
                return result2.ToList();
            }
        }
    }
}

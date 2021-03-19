using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            
        }

        public void Delete(Brand brand)
        {
            
        }

        public List<Brand> GetAll()
        {
            
            
        }

        public List<Brand> GetById(int brandId)
        {
            
        }

        public void Update(Brand brand)
        {
            
        }
    }
}

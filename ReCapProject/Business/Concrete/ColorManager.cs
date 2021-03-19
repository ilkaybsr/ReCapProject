using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            
        }

        public void Delete(Color color)
        {
            
        }

        public List<Color> GetAll()
        {
            
        }

        public List<Color> GetById(int colorId)
        {
            
        }

        public void Update(Color color)
        {
            
        }
    }
}

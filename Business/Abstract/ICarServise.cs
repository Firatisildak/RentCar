﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarServise
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
    }
}

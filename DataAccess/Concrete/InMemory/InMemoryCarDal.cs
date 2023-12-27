using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal(List<Car> car)
        {
            _car = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, ModelYear=2012, Description="uzun kasa"},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=200, ModelYear=2023, Description="uzun kasa"},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=300, ModelYear=2017, Description="uzun kasa"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}

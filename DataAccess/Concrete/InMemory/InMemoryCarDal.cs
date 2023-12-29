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
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=200, ModelYear=2023, Description="kısa kasa"},
                new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=300, ModelYear=2017, Description="kapalı kasa"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car? carToDelete=_car.SingleOrDefault(p=>p.Id==car.Id);
            if (carToDelete != null)
            {
                _car.Remove(carToDelete);
            }else
            {
                Console.WriteLine("Eksik veya Boş değer var.");
            }
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int brandId)
        {
            return _car.Where(p=>p.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car? carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.ModelYear = car.ModelYear;
                carToUpdate.Description = car.Description;
            }
            else
            {
                Console.WriteLine("Eksik veya Boş değer var.");
            }
        }
    }
}

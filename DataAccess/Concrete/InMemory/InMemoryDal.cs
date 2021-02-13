using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1, BrandId=1, ColorId=1, DailyPrice=1000000, Description="Tesla Model S | Black", ModelYear="2020"},
                new Car {Id=2, BrandId=1, ColorId=2, DailyPrice=1000000, Description="Tesla Model S | White", ModelYear="2020"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUdpate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUdpate.BrandId = car.BrandId;
            carToUdpate.ColorId = car.ColorId;
            carToUdpate.DailyPrice = car.DailyPrice;
            carToUdpate.Description = car.Description;
        }
    }
}

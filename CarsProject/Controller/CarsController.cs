using CarsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject.Controller
{
    internal class CarsController
    {
        public List<Car> GetAll()
        {
            using (CarsDBEntities db = new CarsDBEntities())
            {
                return db.Cars.ToList();
            }

        }

        public void AddCar(Car g)
        {
            using (CarsDBEntities gdbe = new CarsDBEntities())
            {
                g.Id = gdbe.Cars.ToList().LastOrDefault().Id + 1;
                gdbe.Cars.Add(g);
                gdbe.SaveChanges();
            }
        }
        public void UpdateCars(int id, Car car)
        {
            using (CarsDBEntities gdbe = new CarsDBEntities())
            {
                var carToUpdate = gdbe.Cars.Where(g => g.Id == id).FirstOrDefault();
                if (carToUpdate != null)
                {
                    carToUpdate.Id = id;
                    carToUpdate.Model = car.Model;
                    carToUpdate.Price = car.Price;
                    carToUpdate.Hp = car.Hp;
                    gdbe.SaveChanges();
                }
            }
        }
        

    }
}

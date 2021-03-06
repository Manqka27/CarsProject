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

         public void DeleteCars(int id)           
         {
            using (CarsDBEntities gdbe = new CarsDBEntities())
            {
                var carsToDelete = gdbe.Cars.Where(g => g.Id == id).FirstOrDefault();
                if (carsToDelete != null)
                {
                    gdbe.Cars.Remove(carsToDelete);
                    gdbe.SaveChanges();
                }
            }
         }
    }
}

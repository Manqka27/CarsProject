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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDotNetCoreMVCApp.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }

        static List<Car> carList = null;
        static Car()
        {
            carList = new List<Car>(){
                new Car()
                {
                    Id = 1,
                    Name = "BMW",
                    ModelName = "BMW S1",
                    Price = 125000
                }
            };
        }

        public static List<Car> SelectCarList()
        {
            return carList;
        }

    }
}

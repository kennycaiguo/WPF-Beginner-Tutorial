using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToListBoxDataBinding
{
    public class Cars
    {
        public static List<Car> GetCars() { 
            return new List<Car>() { 
                new Car(){Owner = "Mike",Type=CarTypes.HatchBack,Brand=CarBrand.VW},
                new Car(){Owner = "Tracey",Type=CarTypes.SUV,Brand=CarBrand.Audi },
                new Car(){Owner = "Jack",Type=CarTypes.Sedan,Brand=CarBrand.BMW},
            }.ToList();
        }
    }
}

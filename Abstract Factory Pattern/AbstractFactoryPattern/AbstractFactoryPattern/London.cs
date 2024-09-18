using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // ConcreteProductB1
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            return 8900000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Tower Bridge", "Buckinghum Palace", "Big Ben" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Madrid : ICapitalCity
    {
        // ConcreteProductB2
        public int GetPopulation()
        {
            return 3200000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Royal Palace", "Prado Museum", "Retiro Park" };
        }
    }
}

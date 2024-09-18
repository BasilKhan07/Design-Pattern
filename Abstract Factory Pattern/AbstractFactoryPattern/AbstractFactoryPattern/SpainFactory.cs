using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // ConcreteFactory2
    public class SpainFactory : IInternaltionalFactory
    {
        public ICapitalCity CreateCapitalCity()
        {
            return new Madrid();
        }

        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
    }
}

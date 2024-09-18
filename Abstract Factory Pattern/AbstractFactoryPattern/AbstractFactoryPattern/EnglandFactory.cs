using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // ConcreteFactory1
    public class EnglandFactory : IInternaltionalFactory
    {
        public ICapitalCity CreateCapitalCity()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}

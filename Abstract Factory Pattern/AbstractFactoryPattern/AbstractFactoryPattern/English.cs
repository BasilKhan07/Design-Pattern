using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // ConcreteProductA1
    public class English : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class GooglePayPayment : IPayment
    {
        public void pay(double amount)
        {
            Console.WriteLine($"Successfully paid {amount} using Google Pay.");
        }
    }
}
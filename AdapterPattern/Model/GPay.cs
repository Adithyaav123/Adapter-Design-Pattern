using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    internal class Gpay
    {
        public void MakePaymentWithGpay(decimal amount)
        {
            Console.WriteLine($"Gapy Payment Gateway processed payment of Rs{amount}");
        }
    }
}

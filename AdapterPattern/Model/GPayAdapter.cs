using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    internal class GPayAdapter:IPaymentProcessor
    {

        private Gpay gpay;

        public GPayAdapter(Gpay gpay)
        {
            this.gpay = gpay;
        }

        public void ProcessPayment(decimal amount)
        {
            gpay.MakePaymentWithGpay(amount);
        }
    }
}

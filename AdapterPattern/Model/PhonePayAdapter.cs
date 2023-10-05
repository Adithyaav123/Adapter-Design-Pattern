using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Model
{
    internal class PhonePayAdapter:IPaymentProcessor
    {
        private Phonepay phonepay;

        public PhonePayAdapter(Phonepay phonepay)
        {
            this.phonepay = phonepay;
        }

        public void ProcessPayment(decimal amount)
        {
            phonepay.PayWithPhonePay(amount);
        }
    }
}

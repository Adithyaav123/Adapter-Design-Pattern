using AdapterPattern.Model;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor gPayAdapter = new GPayAdapter(new Gpay());
            IPaymentProcessor phonePeAdapter = new PhonePayAdapter(new Phonepay());
            IPaymentProcessor newPaymentProcessor = new PaymentProcessor();

            decimal amount = 2000m;

            Console.WriteLine("Using GPay Adapter:");
            gPayAdapter.ProcessPayment(amount);

            Console.WriteLine("\nUsing PhonePe Adapter:");
            phonePeAdapter.ProcessPayment(amount);

            Console.WriteLine("\nUsing New Payment Processor:");
            newPaymentProcessor.ProcessPayment(amount);

            Console.ReadLine();
        }
    }
}
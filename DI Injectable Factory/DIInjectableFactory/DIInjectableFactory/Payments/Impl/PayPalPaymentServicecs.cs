namespace DIInjectableFactory.Payments.Impl
{
    public class PayPalPaymentService : IPaymentService
    {
        public string  pay(double amount)
        {
            return $"Successfully paid {amount} using Pay Pal.";
        }
    }
}

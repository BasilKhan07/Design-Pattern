namespace DIInjectableFactory.Payments.Impl
{
    public class GooglePayPaymentService : IPaymentService
    {
        public string pay(double amount)
        {
            return $"Successfully paid {amount} using Google Pay.";
        }
    }
}

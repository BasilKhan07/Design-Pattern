namespace DIInjectableFactory.Payments.Impl
{
    public class CreditCardPaymentService : IPaymentService
    {
        public string pay(double amount)
        {
            return $"Successfully paid {amount} using Credit Card.";
        }
    }
}

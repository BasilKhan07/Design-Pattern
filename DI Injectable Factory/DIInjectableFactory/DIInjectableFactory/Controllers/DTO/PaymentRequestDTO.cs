using DIInjectableFactory.Payments.Enums;

namespace DIInjectableFactory.Controllers.DTO
{
    public class PaymentRequestDTO
    {
        public double Amount { get; set; }
        public PaymentMethod paymentMethod { get; set; }
    }
}

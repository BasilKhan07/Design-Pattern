using DIInjectableFactory.Payments.Enums;
using DIInjectableFactory.Payments.Impl;

namespace DIInjectableFactory
{
    public class PaymentFactory
    {
        public static IPaymentService Create(IServiceCollection services)
        {
            services.AddScoped<CreditCardPaymentService>();
            services.AddScoped<PayPalPaymentService>();
            services.AddScoped<GooglePayPaymentService>();

            services.AddTransient<Func<PaymentMethod, IPaymentService>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case PaymentMethod.CreditCard:
                        return serviceProvider.GetService<CreditCardPaymentService>();
                    case PaymentMethod.PayPal:
                        return serviceProvider.GetService<PayPalPaymentService>();
                    case PaymentMethod.GooglePay:
                        return serviceProvider.GetService<GooglePayPaymentService>();
                    default:
                        throw new NotSupportedException(
                            $"{key} is not currently supported as payment method");

                }
            });
            return null;
        }
    }
}

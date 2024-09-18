// See https://aka.ms/new-console-template for more information

using FactoryPattern;

IPayment payment = PaymentFactory.create(PaymentMethod.ApplePay);
payment.pay(10000);

using DIInjectableFactory.Controllers.DTO;
using DIInjectableFactory.Payments.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DIInjectableFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly Func<PaymentMethod, IPaymentService> paymentFactoryResolver;

        public PaymentController (Func<PaymentMethod, IPaymentService> paymentFactoryResolver)
        {
            this.paymentFactoryResolver = paymentFactoryResolver;
        }

        [HttpPost("/makePayment")]
        public ActionResult<string> Pay([FromBody] PaymentRequestDTO request)
        {
            IPaymentService paymentService = paymentFactoryResolver(request.paymentMethod);
            string resultMessage = paymentService.pay(request.Amount);
            return Ok(resultMessage);
        }
    }
}

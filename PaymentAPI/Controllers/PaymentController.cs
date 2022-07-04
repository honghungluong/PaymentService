using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentAPI.Interfaces;
using PaymentAPI.Mappers;
using PaymentAPI.Models;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public readonly IPaymentMapper _paymentMapper;

        public PaymentController(IPaymentMapper paymentMapper)
        {
            _paymentMapper = paymentMapper;
        }


        [HttpPost]
        public async Task<ActionResult>CreatePayment(PaymentModel paymentModel)
        {
            var payment =  _paymentMapper.MapToEntity(paymentModel);

            return Ok();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Payment.Core.Services;
using Payment.Domain;
using Payments.API.Validations;

namespace Payments.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly IMapper _mapper;

        public PaymentsController(IPaymentService paymentService, IMapper mapper)
        {
            this._paymentService = paymentService;
            this._mapper = mapper;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<PaymentResource>>> GetAll()
        {
            var payments = await _paymentService.GetAll();
            if (payments == null)
                return NotFound();

            var paymentResource = _mapper.Map<IEnumerable<PaymentD>, IEnumerable<PaymentResource>>(payments);
            return Ok(paymentResource);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentResource>> GetById(int id)
        {
            var payment = await _paymentService.GetById(id);
            if (payment == null)
                return NotFound();

            var paymentResource = _mapper.Map<PaymentD, PaymentResource>(payment);
            return Ok(paymentResource);
        }

        [HttpPost("")]
        public async Task<ActionResult<PaymentResource>> Create([FromBody] SavePaymentResource savePaymentResource)
        {
            var validator = new SavePaymentResourceValidator();
            var validationResult = await validator.ValidateAsync(savePaymentResource);
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var paymentToCreate = _mapper.Map<SavePaymentResource, PaymentD>(savePaymentResource);
            var newPayment = await _paymentService.Create(paymentToCreate);
            var payment = await _paymentService.GetById(newPayment.Id);
            var paymentResource = _mapper.Map<PaymentD, PaymentResource>(payment);
            return Ok(paymentResource);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PaymentResource>> Update(int id, [FromBody] SavePaymentResource savePaymentResource)
        {
            var validator = new SavePaymentResourceValidator();
            var validationResult = await validator.ValidateAsync(savePaymentResource);
            var requestIsInvalid = id == 0 || !validationResult.IsValid;
            if (requestIsInvalid)
                return BadRequest(validationResult.Errors);

            var paymentToUpdate = await _paymentService.GetById(id);
            if (paymentToUpdate == null)
                return NotFound();

            var payment = _mapper.Map<SavePaymentResource, PaymentD>(savePaymentResource);
            await _paymentService.Update(paymentToUpdate, payment);
            var updatePayment = await _paymentService.GetById(id);
            var updatePaymentResource = _mapper.Map<PaymentD, PaymentResource>(updatePayment);
            return Ok(updatePaymentResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMusic(int id)
        {
            if (id == 0)
                return BadRequest();

            var payment = await _paymentService.GetById(id);
            if (payment == null)
                return NotFound();

            await _paymentService.Delete(payment);

            return NoContent();
        }
    }
}



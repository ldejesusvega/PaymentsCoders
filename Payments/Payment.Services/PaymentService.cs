using System.Collections.Generic;
using System.Threading.Tasks;
using Payment.Core;
using Payment.Core.Services;
using Payment.Domain;

namespace Payment.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public async Task<PaymentD> Create(PaymentD payment)
        {
            await _unitOfWork.Payments.AddAsync(payment);
            await _unitOfWork.CommitAsync();
            return payment;
        }

        public async Task Delete(PaymentD payment)
        {
            _unitOfWork.Payments.Remove(payment);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<PaymentD>> GetAll()
        {
            return await _unitOfWork.Payments.GetAllAsync();
        }

        public async Task<PaymentD> GetById(int id)
        {
            return await _unitOfWork.Payments.GetByIdAsync(id);
        }

        public async Task Update(PaymentD paymentToBeUpdate, PaymentD payment)
        {
            paymentToBeUpdate.Concept = payment.Concept;
            paymentToBeUpdate.Date = payment.Date;
            paymentToBeUpdate.Amount = payment.Amount;

            await _unitOfWork.CommitAsync();
        }
    }
}
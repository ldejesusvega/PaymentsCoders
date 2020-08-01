using Payment.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Payment.Core.Services
{
    public interface IPaymentService
    {
        Task<IEnumerable<PaymentD>> GetAll();
        Task<PaymentD> GetById(int id);
        Task<PaymentD> Create(PaymentD payment);
        Task Update(PaymentD paymentToBeUpdate, PaymentD payment);
        Task Delete(PaymentD payment);
    }
}
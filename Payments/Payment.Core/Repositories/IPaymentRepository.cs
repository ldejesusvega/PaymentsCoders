using Payment.Domain;
using System.Threading.Tasks;

namespace Payment.Core.Repositories
{
    public interface IPaymentRepository : IRepository<PaymentD>
    {
        Task<PaymentD> GetWithClientByIdAsync(int id);
        /// Add here any other opertaion that is not included in IRepository
    }
}
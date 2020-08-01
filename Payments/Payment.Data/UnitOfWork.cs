using System.Threading.Tasks;
using Payment.Core;
using Payment.Core.Repositories;
using Payment.Data.Repositories;

namespace Payment.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private PaymentRepository _paymentRepository;
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IPaymentRepository Payments => _paymentRepository = _paymentRepository ?? new PaymentRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
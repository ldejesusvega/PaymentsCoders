using Microsoft.EntityFrameworkCore;
using Payment.Core.Repositories;
using Payment.Domain;
using System.Threading.Tasks;

namespace Payment.Data.Repositories
{
    public class PaymentRepository : Repository<PaymentD>, IPaymentRepository
    {
        public PaymentRepository(DbContext context) : base(context)
        { }
        private ApplicationDbContext ApplicationDbContext
        {
            get { return _context as ApplicationDbContext; }
        }
        public async Task<PaymentD> GetWithClientByIdAsync(int id)
        {
            return await ApplicationDbContext.Payments
                .SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
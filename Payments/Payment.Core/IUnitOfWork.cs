using Payment.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Payment.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPaymentRepository Payments { get; }
        Task<int> CommitAsync();
    }
}

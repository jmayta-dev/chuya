using System.Data.Common;

namespace MW.CHUYA.Application.Common.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task SaveChangesAsync(CancellationToken cancellationToken =  default);
}

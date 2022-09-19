using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Griffon.Domain.Repositories.Base
{
    public interface IBaseRepository<TP, TE> : IUnitOfWork
    {
        Task<TE> AddAsync(TE entity, CancellationToken cancellationToken = default);
        Task<IEnumerable<TE>> AddRangeAsync(IEnumerable<TE> entities, CancellationToken cancellationToken = default);
        TE Update(TE entity);
        IEnumerable<TE> UpdateRange(IEnumerable<TE> entities);
        Task DeleteAsync(TP id, CancellationToken cancellationToken = default);
        Task DeleteRangeAsync(IEnumerable<TP> ids, CancellationToken cancellationToken = default);
        Task<TE> GetAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default);
        Task<IEnumerable<TE>> GetManyAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default);
        Task<IEnumerable<TE>> GetManyAsync(Expression<Func<TE, bool>> condition, int skip = 0, int count = 20, CancellationToken cancellationToken = default);
        Task<IEnumerable<TE>> GetAllAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default);
    }
}

using System.Linq.Expressions;

namespace Griffon.Domain.Services.Base
{
    public interface IBaseManager<TP, TE, TD>
    {
        Task<TD> AddAsync(TE entity, CancellationToken cancellationToken = default);
        Task<IEnumerable<TD>> AddRangeAsync(IEnumerable<TE> entities, CancellationToken cancellationToken = default);
        Task<TD> UpdateAsync(TE entity, CancellationToken cancellationToken = default);
        Task<IEnumerable<TD>> UpdateRangeAsync(IEnumerable<TE> entities, CancellationToken cancellationToken = default);
        Task DeleteAsync(TP id, CancellationToken cancellationToken = default);
        Task DeleteRangeAsync(IEnumerable<TP> ids, CancellationToken cancellationToken = default);
        Task<TD> GetAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default);
        Task<IEnumerable<TD>> GetManyAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default);
        Task<IEnumerable<TD>> GetManyAsync(Expression<Func<TE, bool>> condition, int skip = 0, int count = 20, CancellationToken cancellationToken = default);
        Task<IEnumerable<TD>> GetAllAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default);
    }
}
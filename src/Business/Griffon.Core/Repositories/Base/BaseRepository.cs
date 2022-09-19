using Griffon.Domain.Entities.Base;
using Griffon.Domain.Entities.Base.Abstraction;
using Griffon.Domain.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Griffon.Core.Repositories.Base
{
    public class BaseRepository<TP, TE> : IBaseRepository<TP, TE>
        where TE : BaseEntity<TP>
        where TP : notnull
    {
        private readonly DbContext _dbContext;
        protected readonly DbSet<TE> _entity;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _entity = _dbContext.Set<TE>();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async virtual Task<TE> AddAsync(TE entity, CancellationToken cancellationToken = default)
        {
            await _entity.AddAsync(entity);
            return entity;
        }

        public async virtual Task<IEnumerable<TE>> AddRangeAsync(IEnumerable<TE> entities, CancellationToken cancellationToken = default)
        {
            await _entity.AddRangeAsync(entities, cancellationToken);
            return entities;
        }

        public virtual TE Update(TE entity)
        {
            _entity.Update(entity);
            return entity;
        }

        public virtual IEnumerable<TE> UpdateRange(IEnumerable<TE> entities)
        {
            _entity.UpdateRange(entities);
            return entities;
        }

        public async virtual Task DeleteAsync(TP id, CancellationToken cancellationToken = default)
        {
            var entity = await _entity.FirstOrDefaultAsync(q => q.Id.Equals(id));
            if (entity is not null)
                _entity.Remove(entity);
        }

        public async virtual Task DeleteRangeAsync(IEnumerable<TP> ids, CancellationToken cancellationToken = default)
        {
            var entity = await _entity.Where(q => ids.Equals(q.Id)).ToListAsync();
            if (entity is not null)
                _entity.RemoveRange(entity);
        }

        public async virtual Task<TE> GetAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default)
        {
            var result = await _entity.AsNoTracking().FirstOrDefaultAsync(condition, cancellationToken: cancellationToken);
            return result;
        }

        public async virtual Task<IEnumerable<TE>> GetManyAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default)
        {
            var result = await _entity.AsNoTracking().Where(condition).ToListAsync(cancellationToken);
            return result;
        }

        public async virtual Task<IEnumerable<TE>> GetManyAsync(Expression<Func<TE, bool>> condition, int skip = 0, int count = 20, CancellationToken cancellationToken = default)
        {
            var result = await _entity.AsNoTracking().Where(condition).Skip(skip).Take(count).ToListAsync(cancellationToken);
            return result;
        }

        public async virtual Task<IEnumerable<TE>> GetAllAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default)
        {
            var result = await _entity.AsNoTracking().ToListAsync(cancellationToken);
            return result;
        }
    }
}

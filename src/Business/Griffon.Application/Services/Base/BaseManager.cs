using AutoMapper;
using Griffon.Domain.Entities.Base.Abstraction;
using Griffon.Domain.Repositories.Base;
using Griffon.Domain.Services.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Griffon.Application.Services.Base
{
    public class BaseManager<TP, TE, TD> : IBaseManager<TP, TE, TD>
    {
        protected readonly IBaseRepository<TP, TE> _baseRepository;
        protected readonly IMapper _mapper;

        public BaseManager(IBaseRepository<TP, TE> baseRepository)
        {
            _baseRepository = baseRepository ?? throw new ArgumentNullException(nameof(baseRepository));
        }

        public virtual async Task<TD> AddAsync(TE entity, CancellationToken cancellationToken = default)
        {
            var result = await _baseRepository.AddAsync(entity, cancellationToken);
            await _baseRepository.SaveChangesAsync(cancellationToken);
            return _mapper.Map<TD>(result);
        }

        public virtual async Task<IEnumerable<TD>> AddRangeAsync(IEnumerable<TE> entities, CancellationToken cancellationToken = default)
        {
            var result = await _baseRepository.AddRangeAsync(entities, cancellationToken);
            await _baseRepository.SaveChangesAsync(cancellationToken);
            return _mapper.Map<IEnumerable<TD>>(result);
        }

        public virtual async Task DeleteAsync(TP id, CancellationToken cancellationToken = default)
        {
            await _baseRepository.DeleteAsync(id, cancellationToken);
            await _baseRepository.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<TP> ids, CancellationToken cancellationToken = default)
        {
            await _baseRepository.DeleteRangeAsync(ids, cancellationToken);
            await _baseRepository.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<IEnumerable<TD>> GetAllAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default)
        {
            var result = await _baseRepository.GetAllAsync(condition, cancellationToken);
            return _mapper.Map<IEnumerable<TD>>(result);
        }

        public virtual async Task<TD> GetAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default)
        {
            var result = await _baseRepository.GetAsync(condition, cancellationToken);
            return _mapper.Map<TD>(result);
        }

        public virtual async Task<IEnumerable<TD>> GetManyAsync(Expression<Func<TE, bool>> condition, CancellationToken cancellationToken = default)
        {
            var result = await _baseRepository.GetManyAsync(condition, cancellationToken);
            return _mapper.Map<IEnumerable<TD>>(result);
        }

        public virtual async Task<IEnumerable<TD>> GetManyAsync(Expression<Func<TE, bool>> condition, int skip = 0, int count = 20, CancellationToken cancellationToken = default)
        {
            var result = await _baseRepository.GetManyAsync(condition, skip, count, cancellationToken);
            return _mapper.Map<IEnumerable<TD>>(result);
        }

        public virtual async Task<TD> UpdateAsync(TE entity, CancellationToken cancellationToken = default)
        {
            var result = _baseRepository.Update(entity);
            await _baseRepository.SaveChangesAsync(cancellationToken);
            return _mapper.Map<TD>(result);
        }

        public virtual async Task<IEnumerable<TD>> UpdateRangeAsync(IEnumerable<TE> entities, CancellationToken cancellationToken = default)
        {
            var result = _baseRepository.UpdateRange(entities);
            await _baseRepository.SaveChangesAsync(cancellationToken);
            return _mapper.Map<IEnumerable<TD>>(result);
        }
    }
}

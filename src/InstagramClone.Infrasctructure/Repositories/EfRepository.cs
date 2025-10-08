using InstagramClone.Domain.Entities;
using InstagramClone.Domain.Repositories;
using System.Linq.Expressions;

namespace InstagramClone.Infrasctructure.Repositories;

internal class EfRepository<TEntity>() : IRepository<TEntity>
        where TEntity : class, IEntity 
{
    public Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> where, bool tracking = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TProjection?> FirstOrDefaultAsync<TProjection>(Expression<Func<TEntity, TProjection>> selector, Expression<Func<TEntity, bool>> where, CancellationToken? cancellationToken = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<TEntity>> ToListAsync(Expression<Func<TEntity, bool>>? where = null, bool tracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<TProjection>> ToListAsync<TProjection>(Expression<Func<TEntity, TProjection>> selector, Expression<Func<TEntity, bool>>? where = null, bool tracking = false, CancellationToken? cancellationToken = null)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<TEntity> entity)
    {
        throw new NotImplementedException();
    }
}

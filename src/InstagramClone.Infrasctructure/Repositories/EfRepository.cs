using InstagramClone.Domain.Entities;
using InstagramClone.Domain.Repositories;
using InstagramClone.Infrasctructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InstagramClone.Infrasctructure.Repositories;

internal class EfRepository<TEntity>(AppDbContext context) : IRepository<TEntity>
        where TEntity : class, IEntity {
    protected readonly AppDbContext _dbContext = context;
    // --- ENTIDADE COMPLETA ---

    public async Task<TEntity?> FirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> where, 
        bool tracking = true, 
        CancellationToken cancellationToken = default){

        var query = _dbContext
            .Set<TEntity>()
            .Where(where);

        if (!tracking)
        {
            query = query.AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<IReadOnlyCollection<TEntity>> ToListAsync(Expression<Func<TEntity, bool>>? where = null, bool tracking = false, CancellationToken cancellationToken = default)
    {
        var query = _dbContext.Set<TEntity>().AsQueryable();

        if(!tracking)
            query = query.AsNoTracking();

        if (where is not null)
            query = query.Where(where);

        return await query.ToListAsync(cancellationToken);
    }

    // --- PROJECTION ---
    public Task<TProjection?> FirstOrDefaultAsync<TProjection>(Expression<Func<TEntity, TProjection>> selector, Expression<Func<TEntity, bool>> where, CancellationToken? cancellationToken = null)
    {
        throw new NotImplementedException();
    }
    public virtual async Task AddAsync(TEntity entity, CancellationToken cancellationToken = default)
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


    public void Remove(TEntity entity)
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

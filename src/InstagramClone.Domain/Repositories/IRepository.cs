using InstagramClone.Domain.Entities;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace InstagramClone.Domain.Repositories;

public interface IRepository<TEntity>
    where TEntity : class {

    Task<TEntity?> FirstOrDefaultAsync(
    Expression<Func<TEntity, bool>> where,
    bool tracking = true,
    CancellationToken cancellationToken = default);

    //Task<IReadLeadTEntity> ToListAsync()

}
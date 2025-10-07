using InstagramClone.Domain.Entities;

namespace InstagramClone.Domain.Repositories;

public interface IRepository<TKey, TEntity>
    where TKey : struct, IEquatable<TKey>
    where TEntity : class, IEntity<TKey> {

    //Task<TEntity?> FirstOrDefaultAsync(
    //    )

}

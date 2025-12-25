using System.Linq.Expressions;

namespace N3gD0r.Utils.Models;

public interface IWriteRepository<TEntity, TKey>
    where TEntity : IEntityBase<TKey>
{
    Task CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task DeleteAsync(TKey id, CancellationToken cancellationToken);
}

public interface IReadRepository<TEntity, TKey>
    where TEntity : IEntityBase<TKey>
{
    Task<TEntity> ReadByIdAsync(TKey id, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> ReadAllAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> ReadByAsync(
        Expression<Func<TEntity, bool>> expression,
        CancellationToken cancellationToken = default
    );
}

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
    Task<IEnumerable<TEntity>> ReadAllAsync(
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "",
        CancellationToken cancellationToken = default
    );
    Task<IEnumerable<TEntity>> ReadByAsync(
        Expression<Func<TEntity, bool>>? expression = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "",
        CancellationToken cancellationToken = default
    );
}

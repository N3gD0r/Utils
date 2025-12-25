namespace N3gD0r.Utils.Models;

public abstract class IEntityBase<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreatedAt { get; set; }
}

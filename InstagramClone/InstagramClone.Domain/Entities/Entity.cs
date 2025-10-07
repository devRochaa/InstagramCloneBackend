namespace InstagramClone.Domain.Entities;

public abstract class Entity<TKey> : IEntity<TKey>, IEquatable<Entity<TKey>> 
    where TKey : struct, IEquatable<TKey>
{
    public TKey Id { get; set; }

    public bool Equals(Entity<TKey>? other)
    {
        if (other is null) return false;
        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj) 
        => Equals(obj as Entity<TKey>);

    public override int GetHashCode()
        => Id.GetHashCode();
    
}

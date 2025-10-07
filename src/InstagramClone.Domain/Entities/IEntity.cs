namespace InstagramClone.Domain.Entities;

public interface IEntity<TKey> where TKey : struct, IEquatable<TKey>{
    public TKey Id { get; set; }
}

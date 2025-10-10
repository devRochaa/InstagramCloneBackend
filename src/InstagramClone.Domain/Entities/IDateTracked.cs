namespace InstagramClone.Domain.Entities;

public interface IDateTracked
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset LastUpdatedAt { get; set; }
}

namespace InstagramClone.Domain.Entities;

public interface IDateTracked
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

namespace InstagramClone.Domain.Entities;

internal class UserEntity : Entity<Guid>, IDateTracked, ISoftDelete
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public required string Username { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
    public bool IsEmailConfirmed { get; set; } = false;
    public string? PasswordHash { get; set; }
    public string Bio {  get; set; } = string.Empty;
    public string? PhotoURL { get; set; }
}                           

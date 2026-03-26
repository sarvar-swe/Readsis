namespace Readsis.Core;

public class User
{
    public Guid Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? DisplayName { get; set; }
    public List<string>? Interests { get; set; } = [];
    public Level Level { get; set; }
    public int CurrentStreak { get; set; }
    public int LongestStreak { get; set; }
    public int TotalXP { get; set; }
    public DateOnly LastActivityDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

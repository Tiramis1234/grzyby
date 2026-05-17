using Microsoft.AspNetCore.Identity;

namespace grzyby.Models;

public class User : IdentityUser
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    

    public ICollection<Wpis> Wpisy { get; set; } = new List<Wpis>();
    public ICollection<Komentarz> Komentarze { get; set; } = new List<Komentarz>();
}
namespace grzyby.Models;

public class Komentarz
{
    public int Id { get; set; }
    public string Tresc { get; set; } = string.Empty;
    public DateTime DataDodania { get; set; } = DateTime.UtcNow;
    
    public int WpisId { get; set; }
    public Wpis? Wpis { get; set; }
    
    public string AuthorId { get; set; } = string.Empty;
    public User? Author { get; set; }
}
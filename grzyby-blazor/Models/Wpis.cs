namespace grzyby.Models;

public class Wpis
{
    public int Id { get; set; }
    public string Tytul { get; set; } = string.Empty;
    public string Tresc { get; set; } = string.Empty;
    public DateTime DataDodania { get; set; } = DateTime.UtcNow;
    

    public string AuthorId { get; set; } = string.Empty;
    public User? Author { get; set; }


    public ICollection<Komentarz> Komentarze { get; set; } = new List<Komentarz>();
}
namespace grzyby.Models;

public class Grzyb
{
    public int Id { get; set; }
    public string Nazwa { get; set; } = string.Empty;
    public string Rodzina { get; set; } = string.Empty;
    public string Opis { get; set; } = string.Empty;
    public bool Jadalny { get; set; }
    public string ZdjecieUrl { get; set; } = string.Empty;
}
namespace ProjetMaui.Models;

public class Comment
{
    public int Id { get; set; }
    public string Libelle { get; set; }
    public User User { get; set; }
    public Conference Conference { get; set; }

}

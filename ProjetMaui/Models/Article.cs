namespace ProjetMaui.Models;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsSubmitted { get; set; }
    public enum Article_status{refusé,accepté_avec_modification,accepté }
    public Article_status[] Getstatus { get; set; }
    public string Justificatory { get; set; }
    public User[] ListOfAuthors { get; set; }
    public User[] ListOfRelectors { get; set; }

}

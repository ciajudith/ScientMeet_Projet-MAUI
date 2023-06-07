namespace ProjetMaui.Models;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsParticipant { get; set; }
    public bool IsCopresident { get; set; }
    public bool IsAuthor { get; set; }       
    public bool IsProofReader { get; set; }

    public Comment[] ListOfComments { get; set; }

    public Conference[] ListOfConferencesCreated { get; set; }
    public Conference[] ListOfConferencessParticipated { get; set; }
    public Article[] ListOfArticlesPublished { get; set; }
    public Article[] ListOfArticlesCorrected { get; set; }
    public User() { }

}

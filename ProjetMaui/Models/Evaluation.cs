namespace ProjetMaui.Models;

public class Evaluation
{
    public int NoteFond { get; set; }
    public int NoteForm { get; set; }
    public int NotePert { get; set; }
    public User ProofReader { get; set; }
    public Article Article { get; set; }
    public Evaluation() { }
  
}

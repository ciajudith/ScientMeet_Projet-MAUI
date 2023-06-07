namespace ProjetMaui.Models;

public class Conference
{
    public Conference() { }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sigle { get; set; }
    public string Theme { get; set; }
    public DateTime SubmissionStartDate { get; set; }
    public DateTime SubmissionEndDate { get; set; }
    public DateTime ResultsDate { get; set; }
    public DateTime InscriptionStartDate { get; set; }
    public DateTime InscriptionEndDate { get; set; }
    public DateTime ConferenceStartDate { get; set; }
    public DateTime ConferenceEndDate { get; set; }

    public User[] ListofCopresident { get; set; }
    public User[] ListOfParticipants { get; set; }

    public Conference(int id, string name, string sigle, string theme, DateTime submissionStartDate, DateTime submissionEndDate, DateTime resultsDate, DateTime inscriptionStartDate, DateTime inscriptionEndDate, DateTime conferenceStartDate, DateTime conferenceEndDate, User[] listofCopresident, User[] listOfParticipants)
    {
        Id = id;
        Name = name;
        Sigle = sigle;
        Theme = theme;
        SubmissionStartDate = submissionStartDate;
        SubmissionEndDate = submissionEndDate;
        ResultsDate = resultsDate;
        InscriptionStartDate = inscriptionStartDate;
        InscriptionEndDate = inscriptionEndDate;
        ConferenceStartDate = conferenceStartDate;
        ConferenceEndDate = conferenceEndDate;
        ListofCopresident = listofCopresident;
        ListOfParticipants = listOfParticipants;
    }
}

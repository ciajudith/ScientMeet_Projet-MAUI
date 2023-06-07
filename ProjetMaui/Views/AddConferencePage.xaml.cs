namespace ProjetMaui.Views;

public partial class AddConferencePage : ContentPage
{
    public AddConferencePage(AddConferenceViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
    private void OnAddClicked(object sender, EventArgs e)
    {
        string name = nameEntry.Text;
        string sigle = sigleEntry.Text;
        string theme = themeEntry.Text;

        DateTime submissionStartDate = submissionStartDatePicker.Date;
        DateTime submissionEndDate = submissionEndDatePicker.Date;
        DateTime resultsDate = resultsDatePicker.Date;
        DateTime inscriptionStartDate = inscriptionStartDatePicker.Date;
        DateTime inscriptionEndDate = inscriptionEndDatePicker.Date;
        DateTime conferenceStartDate = conferenceStartDatePicker.Date;
        DateTime conferenceEndDate = conferenceEndDatePicker.Date;

        // Créer une nouvelle instance de Conference avec les valeurs saisies
        Conference conference = new Conference
        {
            Name = name,
            Sigle = sigle,
            Theme = theme,
            SubmissionStartDate = submissionStartDate,
            SubmissionEndDate = submissionEndDate,
            ResultsDate = resultsDate,
            InscriptionStartDate = inscriptionStartDate,
            InscriptionEndDate = inscriptionEndDate,
            ConferenceStartDate = conferenceStartDate,
            ConferenceEndDate = conferenceEndDate
        };

   
        nameEntry.Text = string.Empty;
        sigleEntry.Text = string.Empty;
        themeEntry.Text = string.Empty;
        submissionStartDatePicker.Date = DateTime.Now;
        submissionEndDatePicker.Date = DateTime.Now;
        resultsDatePicker.Date = DateTime.Now;
        inscriptionStartDatePicker.Date = DateTime.Now;
        inscriptionEndDatePicker.Date = DateTime.Now;
        conferenceStartDatePicker.Date = DateTime.Now;
        conferenceEndDatePicker.Date = DateTime.Now;

        // Afficher une notification ou effectuer d'autres actions après l'ajout de la conférence
        DisplayAlert("Succès", "La conférence a été ajoutée.", "OK");
    }
    }


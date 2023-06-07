namespace ProjetMaui.Views;

public partial class ConferencePage : ContentPage
{
	ConferenceViewModel ViewModel;

	public ConferencePage(ConferenceViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
	public async void BookAConference(object sender, EventArgs e)
	{
		
        Button button = (Button)sender;
        Conference conf = (Conference)button.CommandParameter;
        if ((conf.InscriptionStartDate < DateTime.Now)||(conf.InscriptionEndDate > DateTime.Now))
        {
            await DisplayAlert("Information", "La période d'inscription est passée", "J'ai compris");
        }
		else if ((conf.InscriptionStartDate > DateTime.Now) && (conf.InscriptionEndDate < DateTime.Now))
        {
            await DisplayAlert("Information", "C'est bon, Vous pouvez vous inscrire", "J'ai compris");
        }
    }
}

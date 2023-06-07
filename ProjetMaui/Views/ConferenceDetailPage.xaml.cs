namespace ProjetMaui.Views;

public partial class ConferenceDetailPage : ContentPage
{
	public ConferenceDetailPage(ConferenceDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

namespace ProjetMaui.Views;

public partial class UpdateConferencesPage : ContentPage
{
	public UpdateConferencesPage(UpdateConferencesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

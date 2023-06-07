namespace ProjetMaui.Views;

public partial class AddConferencePage : ContentPage
{
	public AddConferencePage(AddConferenceViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

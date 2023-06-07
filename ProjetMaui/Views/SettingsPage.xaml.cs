namespace ProjetMaui.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
	public void LogoutButton_Clicked(object sender, EventArgs e)
	{

	}
    public void SaveButton_Clicked(object sender, EventArgs e)
    {

    }
}

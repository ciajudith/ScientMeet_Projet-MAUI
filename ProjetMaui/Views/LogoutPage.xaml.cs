namespace ProjetMaui.Views;

public partial class LogoutPage : ContentPage
{
	public LogoutPage(LogoutViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

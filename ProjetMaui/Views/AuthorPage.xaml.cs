namespace ProjetMaui.Views;

public partial class AuthorPage : ContentPage
{
	public AuthorPage(AuthorViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

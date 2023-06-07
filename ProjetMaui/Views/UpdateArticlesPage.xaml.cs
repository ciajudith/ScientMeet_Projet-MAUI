namespace ProjetMaui.Views;

public partial class UpdateArticlesPage : ContentPage
{
	public UpdateArticlesPage(UpdateArticlesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

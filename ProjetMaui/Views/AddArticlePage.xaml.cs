namespace ProjetMaui.Views;

public partial class AddArticlePage : ContentPage
{
	public AddArticlePage(AddArticleViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

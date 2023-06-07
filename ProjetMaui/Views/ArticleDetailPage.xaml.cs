namespace ProjetMaui.Views;

public partial class ArticleDetailPage : ContentPage
{
	public ArticleDetailPage(ArticleDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

namespace ProjetMaui.Views;

public partial class ArticlePage : ContentPage
{
	ArticleViewModel ViewModel;

	public ArticlePage(ArticleViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = ViewModel = viewModel;
	}

	protected override async void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		await ViewModel.LoadDataAsync();
	}
}

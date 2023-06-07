namespace ProjetMaui.Views;

public partial class CommentPage : ContentPage
{
	CommentViewModel ViewModel;

	public CommentPage(CommentViewModel viewModel)
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

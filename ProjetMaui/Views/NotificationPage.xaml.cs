namespace ProjetMaui.Views;

public partial class NotificationPage : ContentPage
{
	NotificationViewModel ViewModel;

	public NotificationPage(NotificationViewModel viewModel)
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

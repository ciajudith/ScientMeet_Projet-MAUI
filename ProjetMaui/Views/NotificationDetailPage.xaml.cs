namespace ProjetMaui.Views;

public partial class NotificationDetailPage : ContentPage
{
	public NotificationDetailPage(NotificationDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

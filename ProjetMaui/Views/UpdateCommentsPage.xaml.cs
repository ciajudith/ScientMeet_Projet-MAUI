namespace ProjetMaui.Views;

public partial class UpdateCommentsPage : ContentPage
{
	public UpdateCommentsPage(UpdateCommentsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

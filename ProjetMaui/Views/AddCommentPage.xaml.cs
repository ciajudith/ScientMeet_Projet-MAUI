namespace ProjetMaui.Views;

public partial class AddCommentPage : ContentPage
{
	public AddCommentPage(AddCommentViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

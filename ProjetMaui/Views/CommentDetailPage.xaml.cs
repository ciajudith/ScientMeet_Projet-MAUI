namespace ProjetMaui.Views;

public partial class CommentDetailPage : ContentPage
{
	public CommentDetailPage(CommentDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

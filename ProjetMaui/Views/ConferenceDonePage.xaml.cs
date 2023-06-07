namespace ProjetMaui.Views;

public partial class ConferenceDonePage : ContentPage
{
	public ConferenceDonePage(ConferenceDoneViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

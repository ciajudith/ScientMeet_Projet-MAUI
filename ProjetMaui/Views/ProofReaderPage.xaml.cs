namespace ProjetMaui.Views;

public partial class ProofReaderPage : ContentPage
{
	public ProofReaderPage(ProofReaderViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

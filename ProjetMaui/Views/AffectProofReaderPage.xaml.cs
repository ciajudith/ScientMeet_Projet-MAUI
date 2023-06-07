namespace ProjetMaui.Views;

public partial class AffectProofReaderPage : ContentPage
{
	public AffectProofReaderPage(AffectProofReaderViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

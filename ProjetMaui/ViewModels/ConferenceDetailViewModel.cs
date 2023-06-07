namespace ProjetMaui.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ConferenceDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	Conference item;
}

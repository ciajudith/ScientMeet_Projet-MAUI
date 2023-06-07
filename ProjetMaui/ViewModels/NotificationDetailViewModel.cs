namespace ProjetMaui.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class NotificationDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	SampleItem item;
}

namespace ProjetMaui.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class CommentDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	Comment item;
}

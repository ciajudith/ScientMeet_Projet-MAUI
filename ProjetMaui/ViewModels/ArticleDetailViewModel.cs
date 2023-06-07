namespace ProjetMaui.ViewModels;

[QueryProperty(nameof(Item), "Item")]
public partial class ArticleDetailViewModel : BaseViewModel
{
	[ObservableProperty]
	Article item;
}

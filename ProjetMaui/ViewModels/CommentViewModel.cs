namespace ProjetMaui.ViewModels;

public partial class CommentViewModel : BaseViewModel
{
	readonly CommentDataService dataService;

	[ObservableProperty]
	bool isRefreshing;

	[ObservableProperty]
	ObservableCollection<Comment> items;

	public CommentViewModel(CommentDataService service)
	{
		dataService = service;
	}

	[RelayCommand]
	private async void OnRefreshing()
	{
		IsRefreshing = true;

		try
		{
			await LoadDataAsync();
		}
		finally
		{
			IsRefreshing = false;
		}
	}



	public async Task LoadDataAsync()
	{
		Items = new ObservableCollection<Comment>(await dataService.GetItems());
	}

	[RelayCommand]
	private async void GoToDetails(Comment item)
	{
		await Shell.Current.GoToAsync(nameof(CommentDetailPage), true, new Dictionary<string, object>
		{
			{ "Item", item }
		});
	}
}

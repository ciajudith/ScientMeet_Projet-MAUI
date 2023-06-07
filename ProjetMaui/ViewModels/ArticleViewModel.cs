namespace ProjetMaui.ViewModels;

public partial class ArticleViewModel : BaseViewModel
{
	readonly ArticleDataService dataService;

	[ObservableProperty]
	bool isRefreshing;

	[ObservableProperty]
	ObservableCollection<Article> items;

	public ArticleViewModel(ArticleDataService service)
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
		Items = new ObservableCollection<Article>(await dataService.GetItems());
	}

	[RelayCommand]
	private async void GoToDetails(Article item)
	{
		await Shell.Current.GoToAsync(nameof(ArticleDetailPage), true, new Dictionary<string, object>
		{
			{ "Item", item }
		});
	}
}

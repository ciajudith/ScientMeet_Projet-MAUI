namespace ProjetMaui.ViewModels;

public partial class ConferenceViewModel : BaseViewModel
{
	readonly ConferenceDataService dataService;

	[ObservableProperty]
	bool isRefreshing;

	[ObservableProperty]
	ObservableCollection<Conference> items;

	public ConferenceViewModel(ConferenceDataService service)
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
		Items = new ObservableCollection<Conference>(await dataService.GetItems());
	}

	[RelayCommand]
	private async void GoToDetails(Conference item)
	{
		await Shell.Current.GoToAsync(nameof(ConferenceDetailPage), true, new Dictionary<string, object>
		{
			{ "Item", item }
		});
	}
}

using System.Linq;

namespace ProjetMaui.ViewModels;

public partial class MainViewModel : BaseViewModel
{
	public void DoSomething1()
	{
		for (int i = 0; i < 10; i++)
		{
			System.Diagnostics.Debug.WriteLine(i);
		}
	}

	public void DoSomething2()
	{
		foreach (var i in Enumerable.Range(1, 10))
		{
			System.Diagnostics.Debug.WriteLine(i);
		}
	}
}

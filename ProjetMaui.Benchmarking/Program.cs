using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using ProjetMaui.ViewModels;

namespace ProjetMaui.Benchmarking;

public class Program
{
	// Run this by calling dotnet run -c Release
	public static void Main(string[] args)
	{
		var summary = BenchmarkRunner.Run<Benchmarks>();
	}
}

public class Benchmarks
{
	MainViewModel vmToBenchmark;

	public Benchmarks()
	{
		vmToBenchmark = new MainViewModel();
	}

	[Benchmark]
	public void Option1() => vmToBenchmark.DoSomething1();

	[Benchmark]
	public void Option2() => vmToBenchmark.DoSomething2();
}

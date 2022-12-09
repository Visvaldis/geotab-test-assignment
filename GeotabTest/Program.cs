using GeotabTest.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrettifierModule.Interfaces;


public class Program
{
	public static void Main(string[] args)
	{
		var host = CreateHostBuilder(args).Build();

		var prettifierService = host.Services.GetService<IPrettifier>() 
			?? throw new NullReferenceException("IPrettifier service was null"); ;
		string input;
		int accuracy;
		Console.Write("Enter number for prettify: ");
		input = Console.ReadLine() ?? "";
		do
		{ 	
			Console.Write("Enter accuracy: ");

			if(!int.TryParse(Console.ReadLine(), out accuracy))
			{
				Console.WriteLine("Accuraccy should be an integer, please start over.");
				continue;
			}
			try
			{
				Console.WriteLine(prettifierService.Prettify(input, accuracy), "\n");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				continue;
			}
			Console.WriteLine("Again? \nEnter number to continue or press enter to exit.");
			input = Console.ReadLine() ?? "";
		} while (input != "");
	}


	public static IHostBuilder CreateHostBuilder(string[] args) =>
	Host.CreateDefaultBuilder(args)
		.ConfigureServices((hostContext, services) =>
		{
			services.RegisterDependencies();
		});
}
using GeotabTest.IoC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrettifierModule.Interfaces;

public class Program
{
	public static void Main(string[] args)
	{
		var host = CreateHostBuilder(args).Build();

		var prettifierService = host.Services.GetService<IPrettifier>() ?? throw new NullReferenceException("IPrettifier service was null"); ;

		Console.WriteLine(prettifierService.Prettify("2345"), "\n");		
	}
	public static IHostBuilder CreateHostBuilder(string[] args) =>
	Host.CreateDefaultBuilder(args)
		.ConfigureServices((hostContext, services) =>
		{
			services.RegisterDependencies();
		});
}
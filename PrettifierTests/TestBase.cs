using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using PrettifierTests.IoC;


namespace PrettifierTests
{
	internal class TestBase
	{
		protected IServiceProvider ServiceProvider;

		[SetUp]
		protected void SetUpBase()
		{ 
			ServiceProvider = new ServiceCollection()
				.RegisterDependencies()
				.BuildServiceProvider();
		}
	}
}

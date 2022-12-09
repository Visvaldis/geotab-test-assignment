using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.Interfaces;
using PrettifierTests.IoC;
using NUnit.Framework;

namespace PrettifierTests
{
	internal class Tests: TestBase
	{
		private IPrettifier prettifierService;

		[SetUp]
		public void Setup()
		{
			prettifierService = ServiceProvider.GetService<IPrettifier>()?? throw new NullReferenceException("IPrettifier service was null");
		}

		[TestCase(123456, "")]
		public void Prettify_ShouldReturn_Expected(int number, string expected)
		{
			//arrange

			//act


			//assert

			Assert.Pass();
		}

	}
}
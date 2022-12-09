using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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

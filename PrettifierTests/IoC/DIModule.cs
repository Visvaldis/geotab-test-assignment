using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrettifierModule.IoC;


namespace PrettifierTests.IoC
{
	internal static class DIModule
	{
		public static IServiceCollection RegisterDependencies(this IServiceCollection builder)
		{
			builder.RegisterPrettierModule();
			return builder;
		}
	}
}

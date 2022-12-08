using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeotabTest.IoC
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

using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.IoC;


namespace PrettifierTests.IoC
{
	internal static class DIModule
	{
		public static IServiceCollection RegisterDependencies(this IServiceCollection builder)
		{
			builder.RegisterPrettifierModule();
			return builder;
		}
	}
}

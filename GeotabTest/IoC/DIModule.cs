using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.IoC;


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

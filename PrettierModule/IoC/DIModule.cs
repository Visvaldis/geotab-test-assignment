using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.Interfaces;
using PrettifierModule.Services;


namespace PrettifierModule.IoC
{
	public static class DIModule
	{
		public static void RegisterPrettifierModule(this IServiceCollection builder)
		{
			builder.AddSingleton<IPrettifier, NumberSIPrettifier>();
		}
	}
}

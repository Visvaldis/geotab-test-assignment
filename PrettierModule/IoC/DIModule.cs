using Microsoft.Extensions.DependencyInjection;
using PrettifierModule.Interfaces;
using PrettifierModule.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettifierModule.IoC
{
	public static class DIModule
	{
		public static void RegisterPrettierModule(this IServiceCollection builder)
		{
			builder.AddSingleton<IPrettifier, NumberSIPrettifier>();
		}
	}
}

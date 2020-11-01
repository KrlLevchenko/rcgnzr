using System;

namespace Rcgnzr.Storage.Web.ExceptionHandling
{
	internal class ExceptionHandlerFactory : IExceptionHandlerFactory
	{
		private readonly IServiceProvider _services;

		public ExceptionHandlerFactory(IServiceProvider services)
		{
			_services = services;
		}

		public IExceptionHandler? GetForOrDefault(Type type)
		{
			return _services.GetService(typeof(ExceptionHandlerBase<>).MakeGenericType(type)) as IExceptionHandler;
		}
	}
}
using System;

namespace Rcgnzr.Storage.Web.ExceptionHandling
{
	public interface IExceptionHandlerFactory
	{
		IExceptionHandler? GetForOrDefault(Type type);
	}
}
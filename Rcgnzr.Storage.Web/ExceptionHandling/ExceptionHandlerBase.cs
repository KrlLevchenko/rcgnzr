using System;
using System.Threading.Tasks;

namespace Rcgnzr.Storage.Web.ExceptionHandling
{
	public abstract class ExceptionHandlerBase<TException> : IExceptionHandler where TException : Exception
	{
		public Task<ExceptionHandleResult> Handle(Exception exception)
		{
			return HandleInternal((TException)exception);
		}

		protected abstract Task<ExceptionHandleResult> HandleInternal(TException exception);
	}
}
using System;
using System.Threading.Tasks;

namespace Rcgnzr.Storage.Web.ExceptionHandling
{
	public interface IExceptionHandler
	{
		Task<ExceptionHandleResult> Handle(Exception exception);
	}
}
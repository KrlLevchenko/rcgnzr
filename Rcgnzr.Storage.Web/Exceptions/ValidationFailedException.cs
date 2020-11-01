using System;
using FluentValidation.Results;

namespace Rcgnzr.Storage.Web.Exceptions
{
    public class ValidationFailedException: Exception
    {
        public ValidationResult Result { get; }

        public ValidationFailedException(ValidationResult result)
        {
            Result = result;
        }
    }
}
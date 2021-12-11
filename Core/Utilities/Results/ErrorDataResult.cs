using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, message, true)
        {

        }

        public ErrorDataResult(T data) : base(data, true)
        {

        }

        public ErrorDataResult(string message) : base(default, message, true)
        {

        }

        public ErrorDataResult() : base(default, true)
        {

        }
    }
}

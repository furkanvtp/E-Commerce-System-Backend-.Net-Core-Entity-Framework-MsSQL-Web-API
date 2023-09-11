using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)   //this demek class ın kendisi yani Result
        {                                                           //demek. Result ın tek parametreli olan
            Message = message;                                      //constructorına success i yolla diyorum.
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}

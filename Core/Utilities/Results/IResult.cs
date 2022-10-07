using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için kullanılır
    public interface IResult
    {
        bool Success { get; }
        String Message { get; }
    }
}

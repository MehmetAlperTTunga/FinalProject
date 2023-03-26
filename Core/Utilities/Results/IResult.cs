using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IResult
    {
        //Sadece okumak için yalnızca get
        bool Success { get; }
        string Message { get; }

    }
}

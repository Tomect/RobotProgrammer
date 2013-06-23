using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotProgrammer
{
    class Error
    {
        public enum ErrorType
        {
            Warning,
            Error,
            CriticalError
        }
        public string Text;
        public string Trace;
        public ErrorType Type;
        
    }

    
}

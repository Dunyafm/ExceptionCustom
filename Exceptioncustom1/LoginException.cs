using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExcep
{
    public class LoginException : FormatException
    {
        public LoginException(string msj) : base(msj) { }
        
    }
}
    

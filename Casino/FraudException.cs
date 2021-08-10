using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        // 2 method Constructors
        public FraudException()
            // inherits from base, which is exception,
            // the base exception
            : base () { }
        // overloading; takes in message
        public FraudException(string message)
            //in herits from base which takes one argument, message
            : base (message) { }
    }
}

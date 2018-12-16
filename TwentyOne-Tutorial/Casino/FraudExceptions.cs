using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudExceptions : Exception
    {
        public FraudExceptions()
            :base() { } //inheriting from base Exception
        public FraudExceptions(string message)
            : base(message) { }
    }
}

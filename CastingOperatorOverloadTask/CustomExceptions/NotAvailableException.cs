using System;
using System.Collections.Generic;
using System.Text;

namespace CastingOperatorOverloadTask.CustomExceptions
{
    class NotAvailableException : Exception
    {
        public NotAvailableException(string message):base(message) { }

    }
}

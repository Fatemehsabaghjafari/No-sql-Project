using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public class UnauthorizedTicketAccessException : Exception
    {
        public UnauthorizedTicketAccessException(string message) : base(message) { }
    }

}

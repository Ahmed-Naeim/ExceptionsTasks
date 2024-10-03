using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dublicates
{
    internal class DuplicateException : Exception
    {
        public DuplicateException()
        : base("You Can't Enter a Duplicate Number")
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    internal class VowelException : Exception
    {
        public VowelException() :base("This string doesn't include a vowel"){ }
    }
}

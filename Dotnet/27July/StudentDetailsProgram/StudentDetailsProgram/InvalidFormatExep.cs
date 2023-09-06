using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailsProgram
{
    public class InvalidFormatExep : Exception
    {
        public InvalidFormatExep(string message) :base(message){ }
    }
}

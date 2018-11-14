using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Exceptions
{
    public class InvalidDirectionException :Exception
    {
        public override string Message { get { return "Error : Invalid direction char"; } }
    }
}

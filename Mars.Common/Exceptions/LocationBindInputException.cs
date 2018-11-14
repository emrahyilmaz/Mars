using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Exceptions
{
    public class LocationBindInputException :Exception
    {
        public override string Message { get { return "Error: Location bind input invalid!"; } }
    }
}

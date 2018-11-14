using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Exceptions
{
    public class SurfaceSizeInputException :Exception
    {
        public override string Message => "Error: Surface size input invalid!";
    }
}

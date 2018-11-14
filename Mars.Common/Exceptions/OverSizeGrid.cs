using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Exceptions
{
    public class OverSizeGrid : Exception
    {
        public override string Message
        {
            get
            {
                return "Please enter a smaller value than the Mars surface!";
            }
        }
    }
}

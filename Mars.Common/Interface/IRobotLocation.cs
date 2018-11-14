using Mars.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Interface
{
    public interface IRobotLocation
    {
        int X { get; }
        int Y { get; }
        CompassDirection CompassDirection { get; }
        
    }
}

using Mars.Common.Enums;

namespace Mars.Common.Interface
{
    public interface IRobotLocation1
    {
        CompassDirection CompassDirection { get; }
        int X { get; }
        int Y { get; }

        bool Initilize(string input);
    }
}
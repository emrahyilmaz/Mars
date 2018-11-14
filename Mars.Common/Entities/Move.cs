using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public static class Move
    {
        public static RobotLocation TurnRight(RobotLocation robotLocation)
        {
            int direction = (int)robotLocation.CompassDirection+1;
            if (direction == 5)
                direction = 1;
            robotLocation.CompassDirection =(Enums.CompassDirection)direction;
            return robotLocation;
        }
        public static RobotLocation TurnLeft(RobotLocation robotLocation)
        {
            int direction = (int)robotLocation.CompassDirection -1;
            
            if (direction == 0)
                direction = 4;
            robotLocation.CompassDirection = (Enums.CompassDirection)direction;
            return robotLocation;
        }
        public static RobotLocation Go(RobotLocation robotLocation)
        {
            Enums.CompassDirection direction = robotLocation.CompassDirection;
            switch (direction)
            {
                case Enums.CompassDirection.N:
                    robotLocation.Y = robotLocation.Y+1;
                    break;
                case Enums.CompassDirection.E:
                    robotLocation.X = robotLocation.X+1;
                    break;
                case Enums.CompassDirection.S:
                    robotLocation.Y = robotLocation.Y-1;
                    break;
                case Enums.CompassDirection.W:
                    robotLocation.X = robotLocation.X-1;
                    break;
                default:
                    MaxMinCheck(robotLocation);
                    break;
            }
            return robotLocation;
        }
        public static RobotLocation MaxMinCheck(RobotLocation robotLocation)
        {
            if (robotLocation.X > robotLocation.MaxX)
                robotLocation.X = robotLocation.MaxX;
            if (robotLocation.X < 0)
                robotLocation.X = 0;
            if (robotLocation.Y > robotLocation.MaxY)
                robotLocation.Y = robotLocation.MaxY;
            if (robotLocation.Y < 0)
                robotLocation.Y = 0;


            return robotLocation;
        }


    }
}

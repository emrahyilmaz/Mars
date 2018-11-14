using Mars.Common.Enums;
using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public class InputDedectorFactory
    {
        public IInput getInputObject(string val)
        {
            if (val == null||val=="")
            {
                return null;
            }
            else if (InputMarsSurface(val))
            {
                return new MarsSurface();
            }
            else if (InputRobotDirection(val))
            {
                return new RobotDirection();
            }
            else if (InputRobotLocation(val))
            {
                return new RobotLocation();
            }


            return null;
        }

        public bool InputMarsSurface(string val)
        {
            try
            {
                string[] SizeXY = val.Split(' ');
                int _x = Convert.ToInt32(SizeXY[0]);
                int _y = Convert.ToInt32(SizeXY[1]);
                if (SizeXY.Length != 2)
                    throw new Exception();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool InputRobotDirection(string val)
        {
            char[] directions = val.ToCharArray();
            foreach (var direction in directions)
            {
                try
                {
                    ControlKey kKey;
                    if (Enum.IsDefined(typeof(ControlKey), direction.ToString()))
                    {
                        
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }
        public bool InputRobotLocation(string val)
        {
            try
            {
                string[] inputArr = val.Split(' ');
                int _x = Convert.ToInt32(inputArr[0]);
                int _y = Convert.ToInt32(inputArr[1]);
                string _direction = inputArr[2];


                if (Enum.IsDefined(typeof(CompassDirection), _direction.ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}

using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public static class MessageOutput
    {
        public static bool processOrderMessage(IInput beforeInput,IInput nowInput)
        {
            if (beforeInput.GetType() == typeof(Input) && nowInput.GetType() == typeof(RobotDirection))
            {
                Console.WriteLine("Please first enter the dimensions of the surface of Mars.");
                return false;
            }
            else
                if (beforeInput.GetType() == typeof(RobotLocation) && nowInput.GetType() == typeof(Input))
            {
                Console.WriteLine("Firstly, the first robot must finish the process.");
                return false;
            }
            else
                if (beforeInput.GetType() == typeof(RobotLocation) && nowInput.GetType() == typeof(RobotLocation))
            {
                Console.WriteLine("Please enter the next step.");
                return false;
            }
            else
                if (beforeInput.GetType() == typeof(MarsSurface) && nowInput.GetType() == typeof(Input))
            {
                Console.WriteLine("Please enter the next step.");
                return false;
            }
            else
                if (beforeInput.GetType() == typeof(RobotLocation) && nowInput.GetType() == typeof(MarsSurface))
            {
                Console.WriteLine("Please enter the next step.");
                return false;
            }
            else
                return true;
        }
    }
}

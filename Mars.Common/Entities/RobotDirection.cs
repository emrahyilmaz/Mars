using Mars.Common.Enums;
using Mars.Common.Exceptions;
using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public class RobotDirection : IDirectionString,IInput
    {
        public string DirectionInput { get; private set; }
        public bool Initialize(string input,IInput operation)
        {
            this.DirectionInput = input;
            char[] directions = input.ToCharArray();
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
                        throw new InvalidDirectionException();
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }

        public bool Run(IInput beforeInput,IInput nowInput)
        {
            RobotDirection RobotDirection = (RobotDirection)nowInput;
            try
            {
                MessageOutput.processOrderMessage(beforeInput, nowInput);

                RobotDirection robotDirection= (RobotDirection) nowInput;
                RobotLocation robotLocation = (RobotLocation)beforeInput;
                foreach (var item in robotDirection.DirectionInput.ToCharArray())
                {
                    var controlKey = (ControlKey)Enum.Parse(typeof(ControlKey), item.ToString());
                    if(controlKey==ControlKey.L)
                    {
                        robotLocation = Move.TurnLeft(robotLocation);
                    }else if(controlKey==ControlKey.R)
                    {
                        robotLocation = Move.TurnRight(robotLocation);
                    }
                    else if(controlKey==ControlKey.M)
                    {
                        robotLocation = Move.Go(robotLocation);
                    }
                    
                };
                Console.WriteLine("Robot Location Result:  " + robotLocation.X + " " + robotLocation.Y + " " + robotLocation.CompassDirection.ToString());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Please enter the value other Robot ");
                Console.WriteLine("Please enter new size :");
                beforeInput = new Input();
            }
            catch (Exception)
            {
                Console.WriteLine("Please first enter the dimensions of the surface of Mars.");
                return false;
            }
            return true;
        }
    }
}

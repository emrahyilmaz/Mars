using Mars.Common.Enums;
using Mars.Common.Exceptions;
using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public class RobotLocation : IRobotLocation, IInput
    {

        public int X { get; set; }
        public int MaxX { get; private set;  }

        public int Y { get; set; }
        public int MaxY { get; private set; }

        public CompassDirection CompassDirection { get; set; }

        public bool Initialize(string input, IInput operation)
        {
            try
            {
                string[] inputArr = input.Split(' ');
                int _x = Convert.ToInt32(inputArr[0]);
                int _y = Convert.ToInt32(inputArr[1]);
                string _direction = inputArr[2];

                this.X = _x;
                this.Y = _y;
                this.CompassDirection = (CompassDirection)Enum.Parse(typeof(CompassDirection), _direction, false);//Case insensitive

                if (inputArr.Length != 3)
                    throw new LocationBindInputException();
                if (!(this.X > 0 && this.Y > 0))
                    throw new LocationBindInputException();
                //if (this.X > MarsSurface.X || this.Y>MarsSurface.Y)
                //    throw new OverSizeGrid();

            }
            catch (SurfaceSizeInputException inputException)
            {
                Console.WriteLine(inputException.Message);
                return false;
            }
            catch (OverSizeGrid ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input string!");
                return false;
            }

            return true;
        }

        public bool Run(IInput beforeInput, IInput nowInput)
        {
            RobotLocation RobotLocation = (RobotLocation)nowInput;
            try
            {
                MessageOutput.processOrderMessage(beforeInput, nowInput);
                MarsSurface marsSurface= (MarsSurface)beforeInput;
                this.MaxX= marsSurface.X;
                this.MaxY = marsSurface.Y;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

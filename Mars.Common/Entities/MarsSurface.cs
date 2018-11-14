using Mars.Common.Exceptions;
using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public class MarsSurface : ISurfaceGrid,IInput
    {

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }
        public void GenerateNewMars(int _x,int _y)
        {
            this.X = _x;
            this.Y = _y;
        }
        public bool Initialize(string input,IInput operation)
        {
            try
            {
                string[] SizeXY = input.Split(' ');
                int _x = Convert.ToInt32(SizeXY[0]);
                int _y = Convert.ToInt32(SizeXY[1]);
                this.X = _x;
                this.Y = _y;
                if (SizeXY.Length!= 2)
                    throw new SurfaceSizeInputException();
                if (!(this.X > 0 && this.Y > 0))
                    throw new SurfaceSizeInputException();

            }
            catch (SurfaceSizeInputException inputException)
            {
                Console.WriteLine("Error: Surface size input invalid!");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input string!");
                return false;
            }

            return true;
        }

        public bool Run(IInput beforeInput,IInput nowInput)
        {
            MarsSurface marsSurface = (MarsSurface)nowInput;
            try
            {
                MessageOutput.processOrderMessage(beforeInput, nowInput);

            }
            catch (Exception)
            {
                
                return false;
            }
            return true;
        }
    }
}

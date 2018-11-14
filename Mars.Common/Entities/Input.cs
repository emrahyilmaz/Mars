using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Entities
{
    public class Input : IInput
    {
        public bool Initialize(string inputVal, IInput operation)
        {
            return false;
        }

        public bool Run(IInput beforeInput, IInput nowInput)
        {
            return false;
        }
    }
}

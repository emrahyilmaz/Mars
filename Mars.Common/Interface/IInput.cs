using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Common.Interface
{
    public interface IInput
    {
        bool Initialize(string inputVal, IInput operation);
        bool Run(IInput beforeInput, IInput nowInput);
        
    }
}

using Mars.Common.Entities;
using Mars.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mars!");
           

            IInput beforeInput = new Input() ;
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine();

                Console.WriteLine("Please enter value:");
                var val = Console.ReadLine();
                InputDedectorFactory inputDedectorFactory = new InputDedectorFactory();
                IInput operation = inputDedectorFactory.getInputObject(val);
                if (operation == null)
                {
                    Console.WriteLine("Invalid enter !!! Repeat please :)");
                    continue;
                }
                    
                bool resultInitialize= operation.Initialize(val, operation);
                if (resultInitialize == false)
                {
                    Console.WriteLine("Please repeat enter the value !");
                    continue;
                }
                bool resultRun= operation.Run(beforeInput, operation);
                if (resultRun == false)
                {
                    Console.WriteLine("Please repeat enter the value !");
                    continue;
                }
                beforeInput = operation;
               

            } while (true);

            
            

            Console.ReadLine();
        }
    }
}

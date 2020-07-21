using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_InterfacesMachineExample
{
    public class Car:IMachine
    {
        public void Start()
        {
            Console.WriteLine("Starts with a key.");
        }

        public void Stop()
        {
            Console.WriteLine("Stops by turning the key.");

        }
}
}

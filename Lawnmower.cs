using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10_InterfacesMachineExample
{
    class Lawnmower : IMachine
    {
        public void Start()
        {
            Console.WriteLine("Lawnmower starts with a pull string.");

        }

        public void Stop()
        {
            Console.WriteLine("Lawnmower stops by releasing the handle.");

        }
    }
}

using System;

namespace Lesson10_InterfacesMachineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Lesson10_InterfacesMachineExample");
            
            IMachine Hummer = new Car();
            //Hummer.Start();
            //Hummer.Stop();
            ExecuteMachine(Hummer);

            IMachine Honda = new Car();
            //Honda.Start();
            //Honda.Stop();
            ExecuteMachine(Honda);

            IMachine JohnDeere = new Lawnmower();
            //JohnDeere.Start();
            //JohnDeere.Stop();
            ExecuteMachine(JohnDeere);

        }

        private static void ExecuteMachine(IMachine machine)
        {

        }
    }
}

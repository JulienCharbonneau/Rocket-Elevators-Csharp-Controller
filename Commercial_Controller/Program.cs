using System;
namespace Commercial_Controller
{
    class Program
    {
        static void Main()
        {
    CallButton testbouton = new CallButton(2,"up" );

             System.Console.WriteLine(testbouton.ID);
             System.Console.WriteLine(testbouton.status);


            // int scenarioNumber = Int32.Parse(args[0]);
            // Scenarios scenarios = new Scenarios();
            // scenarios.run(scenarioNumber);
        }
    }
}

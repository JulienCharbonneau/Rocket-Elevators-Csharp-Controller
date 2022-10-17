using System;
namespace Commercial_Controller
{
    class Program
    {
        static void Main()
        {

            FloorRequestButton testFloorRequestButton = new FloorRequestButton(4, "up");



            // CallButton testbouton = new CallButton(2, "up");
            // System.Console.WriteLine(testbouton.ID);
            // System.Console.WriteLine(testbouton.status);
            // System.Console.WriteLine(testbouton.direction);
            // System.Console.WriteLine(testbouton.floor);


            System.Console.WriteLine(testFloorRequestButton.ID);
            System.Console.WriteLine(testFloorRequestButton.status);
            System.Console.WriteLine(testFloorRequestButton.floor);
            System.Console.WriteLine(testFloorRequestButton.direction);


            // Door testDoor = new Door(1, "closed");
            // System.Console.WriteLine(testDoor.ID);
            // System.Console.WriteLine(testDoor.status);




            // int scenarioNumber = Int32.Parse(args[0]);
            // Scenarios scenarios = new Scenarios();
            // scenarios.run(scenarioNumber);
        }
    }
}

using System;
namespace Commercial_Controller
{
    class Program
    {
        static void Main()
        {

            Column testColumn = new Column(1, "online", 2, 2, false);
            System.Console.WriteLine("this is a clolumn: " + testColumn);







            // Elevator testElevator = new Elevator(1, "wait", 12, 1);
            // testElevator.addNewRequest(5);
            // testElevator.addNewRequest(2);
            // testElevator.addNewRequest(10);
            // foreach (int floor in testElevator.floorRequestList)
            //     System.Console.WriteLine("floor request: " + floor);
            // System.Console.WriteLine("======================");
            // testElevator.move();
            // foreach (int floor in testElevator.completedRequestsList)
            //     System.Console.WriteLine("floor served: " + floor);
            // testElevator.operateDoors();
            // System.Console.WriteLine("The door are now : " + testElevator.door.status);
            // System.Console.WriteLine(testElevator.ID);
            // System.Console.WriteLine(testElevator.status);
            // System.Console.WriteLine(testElevator.amountOfFloors);
            // System.Console.WriteLine(testElevator.currentFloor);
            // System.Console.WriteLine("Door ID: " + testElevator.door.ID);
            // System.Console.WriteLine("Door status: " + testElevator.door.status);
            // System.Console.WriteLine(testElevator.floorRequestList);
            // System.Console.WriteLine(testElevator.direction);
            // System.Console.WriteLine(testElevator.overweight);








            // CallButton testbouton = new CallButton(2, "up");
            // System.Console.WriteLine(testbouton.ID);
            // System.Console.WriteLine(testbouton.status);
            // System.Console.WriteLine(testbouton.direction);
            // System.Console.WriteLine(testbouton.floor);


            // FloorRequestButton testFloorRequestButton = new FloorRequestButton(4, "up");
            // System.Console.WriteLine(testFloorRequestButton.ID);
            // System.Console.WriteLine(testFloorRequestButton.status);
            // System.Console.WriteLine(testFloorRequestButton.floor);
            // System.Console.WriteLine(testFloorRequestButton.direction);


            // Door testDoor = new Door(1, "closed");
            // System.Console.WriteLine(testDoor.ID);
            // System.Console.WriteLine(testDoor.status);




            // int scenarioNumber = Int32.Parse(args[0]);
            // Scenarios scenarios = new Scenarios();
            // scenarios.run(scenarioNumber);
        }
    }
}

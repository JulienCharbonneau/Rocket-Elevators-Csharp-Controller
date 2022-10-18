using System.Threading;
using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Elevator
    {
        public string ID;
        public string status = "idle";
        public int amountOfFloors = 2;
        public int currentFloor = 1;
        public Door door = new Door(1, "closed");
        public List<int> floorRequestList = new List<int>();
        public string direction = "down";
        public bool overweight = false;

        public Elevator(string _elevatorID)
        {
            ID = _elevatorID;
            // System.Console.WriteLine("door: ", door);
        }
        public void move()
        {

        }

        public void sortFloorList()
        {
            if (direction == "up")
            {
                floorRequestList.Sort();
            }
            else
            {
                floorRequestList.Sort();
                floorRequestList.Reverse();


            }
        }

        public void operateDoors()
        {
            door.status = "opened";
            System.Console.WriteLine("====================== ");
            System.Console.WriteLine("wait 5 seconds");
            Thread.Sleep(5000);

        }

        public void addNewRequest(int requestedFloor)
        {
            foreach (int floor in floorRequestList)
                if (floor == requestedFloor)
                {
                    break;
                }


            if (currentFloor < requestedFloor)
            {
                direction = "up";
                floorRequestList.Add(requestedFloor);

            }
            if (currentFloor > requestedFloor)
            {
                floorRequestList.Add(requestedFloor);
                direction = "down";
            }



        }

    }
}
using System.Threading;
using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Elevator
    {
        public string ID;
        public string status = "idle";
        public int amountOfFloors = 2;
        public int currentFloor = 33;
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

        public void addNewRequest(int requestedFloor)
        {
            if (floorRequestList.Count == 0)
            {
                floorRequestList.Add(requestedFloor);
            }
            if (currentFloor < requestedFloor)
            {
                direction = "up";
            }
            if (currentFloor > requestedFloor)
            {
                direction = "down";
            }
            System.Console.WriteLine("request list " + requestedFloor);
            System.Console.WriteLine("request direction: " + direction);

        }

    }
}
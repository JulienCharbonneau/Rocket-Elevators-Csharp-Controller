using System.Threading;
using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Elevator
    {
        public int ID;
        public string status;
        public int amountOfFloors;
        public int currentFloor;
        public Door door = new Door(1, "closed");
        public List<int> floorRequestList = new List<int>();
        public string direction = "empty";
        public bool overweight = false;
        public List<int> completedRequestsList = new List<int>();


        public Elevator(int _id, string _status, int _amountOfFloors, int _currentFloor)
        {
            ID = _id;
            status = _status;
            amountOfFloors = _amountOfFloors;
            currentFloor = _currentFloor;
        }
        public void move()
        {
            while (floorRequestList.Count > 0)
            {
                status = "moving";
                sortFloorList();
                int destination = floorRequestList[0];
                if (direction == "up")
                {
                    while (currentFloor < destination)
                    {
                        currentFloor++;
                    }
                }
                else if (direction == "down")
                {
                    while (currentFloor > destination)
                    {
                        currentFloor--;
                    }
                }
                status = "stopped";
                operateDoors();
                floorRequestList.RemoveAt(0);

                completedRequestsList.Add(destination);

            }
            status = "idle";
            direction = "empty";

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
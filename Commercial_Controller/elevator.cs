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
        public List<int> floorRequestsList = new List<int>();
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
            while (floorRequestsList.Count > 0)
            {
                status = "moving";
                sortFloorList();
                int destination = floorRequestsList[0];
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
                floorRequestsList.RemoveAt(0);

                completedRequestsList.Add(destination);

            }
            status = "idle";
            direction = "empty";

        }

        public void sortFloorList()
        {
            if (direction == "up")
            {
                floorRequestsList.Sort();
            }
            else
            {
                floorRequestsList.Sort();
                floorRequestsList.Reverse();


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

            if (floorRequestsList.Contains(requestedFloor))
            {

            }
            else
            {

                floorRequestsList.Add(requestedFloor);
            }


            if (currentFloor < requestedFloor)
            {
                direction = "up";

            }
            if (currentFloor > requestedFloor)
            {
                direction = "down";
            }



        }

    }
}
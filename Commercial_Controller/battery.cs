using System;
using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Battery
    {
        public int ID;
        public string status = "online";
        public List<Column> columnsList = new List<Column>();
        public List<FloorRequestButton> floorRequestsButtonsList = new List<FloorRequestButton>();
        public int amountOfColumns;
        public int amountOfFloors;
        public int amountOfBasements;

        public int amountOfElevatorPerColumn;
        public int columnID = 1;
        public int floorRequestButtonID = 1;

        public int buttonFloor = -1;


        public Battery(int _ID, int _amountOfColumns, int _amountOfFloors, int _amountOfBasements, int _amountOfElevatorPerColumn)
        {
            ID = _ID;
            amountOfColumns = _amountOfColumns;
            amountOfFloors = _amountOfFloors;
            amountOfBasements = _amountOfBasements;
            amountOfElevatorPerColumn = _amountOfElevatorPerColumn;

            if (amountOfBasements > 0)
            {
                createBasementFloorRequestButtons(amountOfBasements);
                createBasementColumn(amountOfBasements, amountOfElevatorPerColumn);
                amountOfColumns--;
            }

            createFloorRequestButtons(amountOfFloors);
            createColumns(amountOfColumns, amountOfFloors, amountOfElevatorPerColumn);
        }

        public void createBasementColumn(int amountOfBasements, int amountOfElevatorPerColumn)
        {
            List<int> servedFloors = new List<int>();

            int floor = -1;
            for (int i = 0; i < amountOfBasements; i++)
            {
                servedFloors.Add(floor);
                floor--;
            }
            Column column = new Column(columnID, "online", amountOfBasements, amountOfElevatorPerColumn, servedFloors, true);
            columnsList.Add(column);
            columnID++;


        }

        public void createColumns(int amountOfColumns, int amountOfFloors, int amountOfElevatorPerColumn)
        {

            decimal division = amountOfFloors / amountOfColumns;// the variable division is to hold temporary the value of the divison 
            decimal amountOfFloorsPerColumn = Math.Ceiling(division);
            int floor = 1;
            for (int i = 0; i < amountOfColumns; i++)
            {
                List<int> servedFloors = new List<int>();
                for (int j = 0; j < amountOfFloorsPerColumn; j++)
                {
                    if (floor <= amountOfFloors)
                    {
                        servedFloors.Add(floor);
                        floor++;

                    }

                }
                Column column = new Column(columnID, "online", amountOfFloors, amountOfElevatorPerColumn, servedFloors, false);
                columnsList.Add(column);
                columnID++;
            }
            System.Console.WriteLine("amount of floors per column: " + amountOfFloorsPerColumn);
        }


        public void createFloorRequestButtons(int amountOfFloors)
        {
            int buttonFloor = 1;
            for (int i = 0; i < amountOfFloors; i++)
            {
                FloorRequestButton floorRequestButton = new FloorRequestButton(floorRequestButtonID, "OFF", buttonFloor, "Up");
                floorRequestsButtonsList.Add(floorRequestButton);
                floorRequestButtonID++;
                buttonFloor++;

            }
        }

        public void createBasementFloorRequestButtons(int amountOfBasements)
        {
            int buttonFloor = -1;

            for (int i = 0; i < amountOfBasements; i++)
            {
                FloorRequestButton floorRequestButton = new FloorRequestButton(floorRequestButtonID, "OFF", buttonFloor, "Down");
                floorRequestsButtonsList.Add(floorRequestButton);

                buttonFloor--;
                floorRequestButtonID++;
            }

        }
        public void findBestColumn(int _requestedFloor)
        {

        }
        //Simulate when a user press a button at the lobby
        public void assignElevator(int _requestedFloor, string _direction)
        {

        }
    }
}


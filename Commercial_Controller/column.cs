using System;
using System.Collections.Generic;

namespace Commercial_Controller
{
    public class Column
    {
        public int ID;
        public string status;
        public int amountOfFloors;
        public int amountOfElevators;
        public List<Elevator> elevatorsList = new List<Elevator>();
        public List<CallButton> callButtonsList = new List<CallButton>();
        public List<int> servedFloorsList = new List<int>();
        public bool isBasement;



        public Column(int _ID, string _status, int _amountOfFloors, int _amountOfElevators, bool _isBasement)
        {
            ID = _ID;
            status = _status;
            amountOfFloors = _amountOfFloors;
            amountOfElevators = _amountOfElevators;
            isBasement = _isBasement;
            createCallButtons(amountOfFloors, isBasement);
        }
        public void createCallButtons(int amountOfFloors, bool isBasement)
        {
            if (isBasement)
            {
                int buttonFloor = -1;
                int callButtonID = 1;
                for (int i = 0; i < amountOfFloors; i++)
                {
                    CallButton callButton = new CallButton(callButtonID, "OFF", buttonFloor, "Up");
                    callButtonsList.Add(callButton);
                    buttonFloor--;
                    callButtonID++;

                }
            }
            else
            {
                int buttonFloor = 1;
                int callButtonID = 1;
                for (int i = 0; i < amountOfFloors; i++)
                {
                    CallButton callButton = new CallButton(callButtonID, "OFF", buttonFloor, "Down");
                    callButtonsList.Add(callButton);
                    buttonFloor++;
                    callButtonID++;
                    Console.WriteLine("callButton id: " + callButton.ID);
                    System.Console.WriteLine("button in the list id: " + callButtonsList[i].ID);
                }

                System.Console.WriteLine("next button floor:" + buttonFloor);
            }
        }

        //Simulate when a user press a button on a floor to go back to the first floor
        // public Elevator requestElevator(int userPosition, string direction)
        // {

        // }

    }
}
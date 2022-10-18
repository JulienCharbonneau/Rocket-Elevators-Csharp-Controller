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
        public List<CallButton> callButtonsList = new List<CallButton>();
        public List<int> servedFloorsList = new List<int>();
        public bool isBasement;
        public BestElevatorInformations bestElevatorInformations = new BestElevatorInformations();

        public List<Elevator> elevatorsList = new List<Elevator>();


        public Column(int _ID, string _status, int _amountOfFloors, int _amountOfElevators, bool _isBasement)
        {
            ID = _ID;
            status = _status;
            amountOfFloors = _amountOfFloors;
            amountOfElevators = _amountOfElevators;
            isBasement = _isBasement;
            createElevators(amountOfFloors, amountOfElevators);
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

        public void createElevators(int _amountOfFloors, int _amountOfElevators)
        {
            int elevatorID = 1;
            for (int i = 0; i < _amountOfElevators; i++)
            {
                Elevator elevator = new Elevator(elevatorID, "idle", _amountOfElevators, 1);
                elevatorsList.Add(elevator);
                elevatorID++;
                System.Console.WriteLine("elevator in the list id:" + elevatorsList[i].ID);
            }
        }
        //  Simulate when a user press a button on a floor to go back to the first floor
        public void requestElevator(int userPosition, string direction)
        {
            Elevator elevator = findElevator(userPosition, direction);
            elevator.addNewRequest(1);
            elevator.move();
            elevator.addNewRequest(1);
            elevator.move();
        }


        public Elevator findElevator(int requestedFloor, string requestedDirection)
        {

            if (requestedFloor == 1)
            {
                foreach (Elevator elevator in elevatorsList)
                {
                    if (elevator.currentFloor == 1 && elevator.status == "stopped")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(1, elevator, bestElevatorInformations, requestedFloor);
                    }
                    else if (elevator.currentFloor == 1 && elevator.status == "idle")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(2, elevator, bestElevatorInformations, requestedFloor);
                    }
                    else if (elevator.currentFloor < 1 && elevator.direction == "up")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(3, elevator, bestElevatorInformations, requestedFloor);
                    }
                    else if (elevator.status == "idle")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(4, elevator, bestElevatorInformations, requestedFloor);

                    }
                    else
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(5, elevator, bestElevatorInformations, requestedFloor);

                    }

                    System.Console.WriteLine("info best elevator " + bestElevatorInformations.bestElevator.ID);
                }
            }
            else
            {
                foreach (Elevator elevator in elevatorsList)
                {
                    if (requestedFloor == elevator.currentFloor && elevator.status == "stopped" && requestedDirection == elevator.direction)
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(1, elevator, bestElevatorInformations, requestedFloor);

                    }
                    else if (requestedFloor > elevator.currentFloor && elevator.direction == "up" && requestedDirection == "up")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(2, elevator, bestElevatorInformations, requestedFloor);
                    }
                    else if (requestedFloor < elevator.currentFloor && elevator.direction == "down" && requestedDirection == "down")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(2, elevator, bestElevatorInformations, requestedFloor);

                    }
                    else if (elevator.status == "idle")
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(4, elevator, bestElevatorInformations, requestedFloor);
                    }
                    else
                    {
                        bestElevatorInformations = checkIfElevatorIsBetter(5, elevator, bestElevatorInformations, requestedFloor);
                    }
                }

            }
            return bestElevatorInformations.bestElevator;
        }

        public BestElevatorInformations checkIfElevatorIsBetter(int scoreToCheck, Elevator newElevator, BestElevatorInformations info, int floor)
        {
            if (scoreToCheck < info.bestScore)
            {
                info.bestScore = scoreToCheck;
                info.bestElevator = newElevator;
                info.referenceGap = Math.Abs(newElevator.currentFloor - floor);
            }
            else if (scoreToCheck == info.bestScore)
            {
                int gap = Math.Abs(newElevator.currentFloor - floor);
                if (info.referenceGap > gap)
                {
                    info.bestElevator = newElevator;
                    info.referenceGap = gap;
                }

                System.Console.WriteLine("gap: " + gap);
            }
            System.Console.WriteLine("info bestScore:" + info.bestScore);
            System.Console.WriteLine("info bestElevatorID:" + info.bestElevator.ID);
            System.Console.WriteLine("info reference Gap: " + info.referenceGap);
            System.Console.WriteLine("info : " + info.bestElevator.ID);

            return info;

        }


    }



    public class BestElevatorInformations
    {
        public int bestScore = 6;
        public int referenceGap = 10000000;
        public Elevator bestElevator;

        public BestElevatorInformations()
        {

        }
    }
}
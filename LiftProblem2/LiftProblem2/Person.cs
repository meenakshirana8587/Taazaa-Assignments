﻿using Lift.Enums;
using Lift.Exceptions;

namespace Lift.Entities
{
    public class Person
    {

        public event ButtonPressedForCallingTheLift ButtonPressed;

        public static int CurrentFloor { get; set; }
        public int DestinationFloor { get; set; }

        public WaitingStatus WaitingStatus { get; set; }

        public Direction DirectionToGoIn
        {
            get
            {
                return CurrentFloor > DestinationFloor ? Direction.GoingDown : Direction.GoingUp;
            }
        }

        public Person(int currentFloor, int destinationFloor)
        {
            CurrentFloor = currentFloor;
            DestinationFloor = destinationFloor;
            WaitingStatus = WaitingStatus.Waiting;
        }

        public void PressButton()
        {
            this.ButtonPressed(this.DirectionToGoIn);
        }


        

        public void SetReached()
        {
            this.WaitingStatus = WaitingStatus.Reached;
        }

        public void SetOnboard()
        {
            this.WaitingStatus = WaitingStatus.BoardedLift;
        }
    }
}
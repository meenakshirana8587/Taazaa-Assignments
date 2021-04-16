using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lift.Entities
{
    public class Lift
    {
        public delegate void LiftArrivedAtAFloor(int floorNumber);
        public event LiftArrivedAtAFloor LiftArriverAtAFloor;
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }
       public Direction LiftDirection { get; set; }

        public Lift(int capacity)
        {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
            this.LiftDirection = Direction.Stationary;
        }


        public void Start()
        {
            this.LiftDirection = Direction.GoingUp;
            this.LiftArriverAtAFloor(this.CurrentFloor);
        }

        public void OnboardPeople(List<Person> people)
        {
            this.People.AddRange(people);
        }

        public List<Person> OffboardPeople(int floorNumber)
        {
            var peopleToOffboard = this.People.Where(p => p.DestinationFloor == floorNumber).ToList();
            this.People = this.People.Where(p => p.DestinationFloor != floorNumber).ToList();
            return peopleToOffboard;
        }

        public int GetAvailableCapacity()
        {
            return this.Capacity - this.People.Count;
        }
        //if current floor is not top floor , lift can move up
        public  void MoveUp()
        {
            if(this.CurrentFloor<Building.Floors.Length)
            {
                this.CurrentFloor = this.CurrentFloor + 1;
            }
        }
        ////if current floor is not Zero or less floor , lift can move down
        public void MoveDown()
        {
            if(CurrentFloor>0)
            {
                this.CurrentFloor = this.CurrentFloor - 1;


            }
        }
        //checking for the lift capacity

        public  bool IsFull()
        {
            if (this.People.Count == this.Capacity)
            {
                return true;
            }
            else return false;
        }
        public void EnterInTheLift()//person enters the lift if lift is not full
        {
            if(!IsFull())
            {
                //code to add person to the lift.
            }
            else
            {
                Console.WriteLine("Alert alarm: Lift is full");
            }
        }
    }
    
}
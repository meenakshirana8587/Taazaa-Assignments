using Lift.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lift.Entities
{
    public class Lift
    {
        public int Capacity { get; set; }
        public List<Person> People { get; set; }
        public int CurrentFloor { get; set; }
       // public Direction Direction { get; set; }

        public Lift(int capacity)
        {
            this.CurrentFloor = 0;
            this.Capacity = capacity;
            
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
    }
    public void EnterInTheLift()
    {

    }
}
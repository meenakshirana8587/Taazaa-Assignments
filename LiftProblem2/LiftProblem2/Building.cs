using System.Linq;
using Lift.Enums;

namespace Lift.Entities
{
    public class Building
    {
        public static Floor[] Floors { get; set; }

        public Lift Lift { get; set; }

        public Building(int liftCapacity, int[][] floorAndPeopleComposition)

        {
            Floors = floorAndPeopleComposition.Select((floorComposition, floorNumber) =>
            {
                var floor = new Floor(floorNumber, floorComposition);
                floor.ButtonPressedForCallingTheLift += this.LiftRequested;
                return floor;
            }).ToArray();

            Lift = new Lift(liftCapacity);
        }

        public void LiftRequested(Direction direction, int floorNumberRequestedOn)
        {


            //if lift's direction is upwards the lift will move up untill it serves all the people from top.

            if (direction == Direction.GoingUp)
            {
                while (floorNumberRequestedOn < Person.CurrentFloor)
                {



                    Lift.MoveUp();


                }
            }

            //if lift's direction is downwards the lift will move down untill it serves all the people from bottom.

            else if (direction == Direction.GoingDown)
            {
                while (floorNumberRequestedOn < Person.CurrentFloor)
                {

                    Lift.MoveDown();
                }
            }
                
            }

        }
    }

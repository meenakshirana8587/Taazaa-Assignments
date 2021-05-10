using System;
using System.Collections.Generic;
using System.Text;

namespace TwoJoggers
{
    public class UserInputs
    {
        public int BobLapLength { get; set; }
        public int CharlesLapLength { get; set; }
        public void TakeInput()
        {
            Console.WriteLine("Please enter the length of the lap for Bob");
            BobLapLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the length of the lap for Charles");
            CharlesLapLength = Convert.ToInt32(Console.ReadLine());


        }


    }
}

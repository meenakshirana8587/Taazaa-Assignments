using System;

namespace TwoJoggers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            UserInputs userinput = new UserInputs();
            userinput.TakeInput();
            Operations operation = new Operations();
            Console.WriteLine("Number of laps covered by Bob and Charles respectively"+ operation.NbrOfLaps(userinput.BobLapLength, userinput.CharlesLapLength));
        }
    }
}

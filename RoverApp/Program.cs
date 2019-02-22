using Rover.Library;
using System;
using System.Collections.Generic;

namespace RoverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> commands = new List<String>();
            commands.Add("88");
            commands.Add("12 E");
            commands.Add("MMLMRMMRRMML");
            Rover.Library.Rover rover = new Rover.Library.Rover();
            Position roverPosition = new Position();
            rover.NavigateRover(commands, roverPosition);
            rover.PrintRoverPosition();
            

        }
    }
}

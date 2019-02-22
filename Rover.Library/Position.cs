using System;

namespace Rover.Library
{
    public class Position
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
    
        public Direction RoverDirection { get; set; }

        public enum Direction
        {
            N,
            E,
            S,
            W
        }
        public void getRoverPosition(string position)
        {
            XCoordinate = Int32.Parse(position.Substring(0, 1));
            YCoordinate = Int32.Parse(position.Substring(1, 1));
            RoverDirection = (Position.Direction)Enum.Parse(typeof(Position.Direction), position.Substring(3, 1));
        }

    }
}

using System;
using System.Collections.Generic;

namespace Rover.Library
{
    public class Rover
    {
        private Position _roverPosition;
        private int Boundary;

        String Actions { get; set; }

        int[,] MarsArea { get; set; }
        
     
        private void RotateRight()
        {
            var roverDirection = _roverPosition.RoverDirection;
            switch (roverDirection)
            {
                case (Position.Direction.E):
                    _roverPosition.RoverDirection = Position.Direction.S;
                    break;

                case (Position.Direction.S):
                    _roverPosition.RoverDirection = Position.Direction.W;
                    break;

                case (Position.Direction.W):
                    _roverPosition.RoverDirection = Position.Direction.N;
                    break;
                case (Position.Direction.N):
                    _roverPosition.RoverDirection = Position.Direction.E;
                    break;
                default:
                    throw new ArgumentException(string.Format("Unknown Direction: {0}", roverDirection));
            }
        }

            private void RotateLeft()
            {
                var roverDirection = _roverPosition.RoverDirection;
                switch (roverDirection)
                {
                    case (Position.Direction.E):
                    _roverPosition.RoverDirection = Position.Direction.N;
                        break;

                    case (Position.Direction.S):
                    _roverPosition.RoverDirection = Position.Direction.E;
                        break;

                    case (Position.Direction.W):
                    _roverPosition.RoverDirection = Position.Direction.S;
                        break;
                    case (Position.Direction.N):
                    _roverPosition.RoverDirection = Position.Direction.W;
                        break;
                    default:
                        throw new ArgumentException(string.Format("Unknown Direction: {0}", roverDirection));
            }
            }

        private void MoveRover()
        {
            var roverDirection = _roverPosition.RoverDirection;
            if(_roverPosition.XCoordinate == Boundary - 1 || _roverPosition.YCoordinate == Boundary - 1)
            {
                throw new IndexOutOfRangeException("Rover can't move further");
            }

            switch (roverDirection)
            {
                case (Position.Direction.E):
                    _roverPosition.XCoordinate++;
                    break;

                case (Position.Direction.S):
                    _roverPosition.YCoordinate--;
                    break;

                case (Position.Direction.W):
                    _roverPosition.XCoordinate--;
                    break;
                case (Position.Direction.N):
                    _roverPosition.YCoordinate++;
                    break;
                default:
                    throw new ArgumentException(string.Format("Unknown Direction: {0}", roverDirection));
            }
        }

            private void OperateRover(string actions)
            {
                foreach (var action in actions)
                {
                    switch (action)
                    {
                    case ('M'):
                        MoveRover();
                        break;
                    case ('L'):
                        RotateLeft();
                        break;
                    case ('R'):
                        RotateRight();
                        break;
                        default:
                            throw new ArgumentException(string.Format("Action not recognized: {0}", action));
                    }
            }
            }
        
        private void ReadRoverCommands(List<String> commands, Position roverPosition)
        {
            Actions = commands[2];
            var position = commands[1];
            _roverPosition.getRoverPosition(position);
            Boundary = Int32.Parse(commands[0].Substring(0,1));
            MarsArea = new int[Boundary, Boundary];
        }

        public string NavigateRover(List<String> commands, Position roverPosition)
        {
            _roverPosition = roverPosition;
            ReadRoverCommands(commands,roverPosition);
            OperateRover(Actions);
            return String.Format("{0}{1} {2}", _roverPosition.XCoordinate, _roverPosition.YCoordinate, _roverPosition.RoverDirection);
        }

        public void PrintRoverPosition()
        {
            Console.WriteLine(String.Format("Rover Position is -- XCoordinate: {0}  YCoordinate:  {1}  Direction : {2} ", _roverPosition.XCoordinate, _roverPosition.YCoordinate, _roverPosition.RoverDirection));
            Console.ReadKey();
        }
    



}

    }


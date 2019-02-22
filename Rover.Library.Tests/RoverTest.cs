using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Moq;

namespace Rover.Library.Tests
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void CanCorrectlyRotateRight_GivenRightRotationCommand_ReturnsCorrectRoverDirection()
        {
            var rover = new Rover();
            Position roverPosition = new Position();
            var result = rover.NavigateRover(new List<string> { "88", "12 E", "R" }, roverPosition);
            Assert.AreEqual("12 S", result);
            
        }
        [TestMethod]
        public void CanCorrectlyRotateLeft_GivenLeftRotationCommand_ReturnsCorrectRoverDirection()
        {
            var rover = new Rover();
            Position roverPosition = new Position();
            var result = rover.NavigateRover(new List<string> { "88", "12 E", "L" }, roverPosition);
            Assert.AreEqual("12 N", result);

        }
        [TestMethod]
        public void CanCorrectlyMoveRover_GivenMoveCommand_ReturnsCorrectRoverDirectionAndCoordinates()
        {
            var rover = new Rover();
            Position roverPosition = new Position();
            var result = rover.NavigateRover(new List<string> { "88", "12 E", "M" }, roverPosition);
            Assert.AreEqual("22 E", result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanCorrectlyVerifyMovementInput_GivenIncorrectInput_ThrowsException()
        {
            var rover = new Rover();
            Position roverPosition = new Position();
            var result = rover.NavigateRover(new List<string> { "88", "12 E", "8" }, roverPosition);
            
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CanCorrectlyVerifyAreaInput_GivenIncorrectInput_ThrowsException()
        {
            var rover = new Rover();
            Position roverPosition = new Position();
            rover.NavigateRover(new List<string> { "q8", "12 E", "8" }, roverPosition);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CheckIfAreaIsOutOfBounds_GivenMovingOutOfBounds_ThrowsException()
        {
            var rover = new Rover();
            Position roverPosition = new Position();
            rover.NavigateRover(new List<string> { "88", "77 E", "MMMMMMMMM" }, roverPosition);

        }






    }
}

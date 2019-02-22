using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Rover.Library.Tests
{
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CanCorrectlyVerifyAreaInput_GivenIncorrectInput_ThrowsException()
        {
            var input = "1n E";
            Position roverPosition = new Position();
            roverPosition.getRoverPosition(input);
            
        }
    }
}

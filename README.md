# RoverApp
Running the solution:

I have created a console app that uses the Rover.Library. The main program creates the input using a list and adds all the commands that wll be sent to Rover Class in Rover.Library. Running the main class should run

Design Approach :

I created Rover.Library for all things rover. Position Class has all the information regarding the orientation of the rover. Position is a property in the Rover class and get changed accordingly to all the movements done by the rover.

The Rover class tests(Rover.Library.Tests) the validity of the movements, or the rotation. The validity of the input is also tested. The Position Class has very little funtionality and thus only tests the input. The main purpose of Position Class is set the position of the rover.

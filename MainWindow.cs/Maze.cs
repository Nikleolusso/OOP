using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainWindow.cs
{
    public class Maze
    {
        private Room startRoom;
        private Room winningRoom;
        private Room losingRoom;

        public Maze()
        {
            Room kitchen = new Room("Kitchen");
            Room livingRoom = new Room("Living Room");
            Room exit = new Room("Exit");
            Room bathroom= new Room("Bathroom");
            Room bedroom = new Room("Bedroom");
            Room tortureChamber = new Room("Torture Chamber");

            kitchen.setConnectedRooms(null, livingRoom, bathroom, null); // N, E, S, W
            livingRoom.setConnectedRooms(null, exit, null, kitchen); // N, E, S, W
            exit.setConnectedRooms(null, null, null, livingRoom); // N, E, S, W
            bathroom.setConnectedRooms(kitchen, bedroom, null, null); // N, E, S, W
            bedroom.setConnectedRooms(livingRoom, null, tortureChamber, bathroom); // N, E, S, W
            tortureChamber.setConnectedRooms(bedroom, null, null, null); // N, E, S, W

            this.startRoom = bathroom;
            this.winningRoom = exit;
            this.losingRoom = tortureChamber;
            // it is sufficient to only store starting and exiting points, because all other rooms can be accessed via the direction references set
            // the rooms aren't deleted by the garbage collector, as long as there are references to them. Setting up the map gives at least one refernce to each room
        }

        public Room getStartRoom()
        {
            return this.startRoom;
        }

        public Room getWinningRoom()
        {
            return this.winningRoom;
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }
    }
}
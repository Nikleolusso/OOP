using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainWindow.cs
{
    public class Room
    {
        private bool lockingDoor;
        private bool ownsKey;
        private bool monsterTriggered;
        private string name;

        private Room north;
        private Room east;
        private Room south;
        private Room west;

        public void monster(bool monsterTriggered)
        {
            if (monsterTriggered == false)
            {
                Console.WriteLine("Buhahaha");
                monsterTriggered = true;
            }
        }

        public void door(bool ownsKey, bool lockingDoor)
        {
            if (lockingDoor == true && ownsKey == false)
            {
                Console.WriteLine("Door is locked! A key would be very useful...");
            }
            if (lockingDoor == true && ownsKey == true)
            {
                Console.WriteLine("You unlocked the door!");
                lockingDoor = false;
            }
            else
            {
                Console.WriteLine("Enter, my friend...");
            }
        }

        public Room(string name)
        {
            this.name = name;
            this.north = null;
            this.east = null;
            this.south = null;
            this.west = null;
        }
        //pass rooms from main and store them
        public void setConnectedRooms(Room north, Room east, Room south, Room west)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;
        }

        public string getName()
        {
            return name;
        }
        //
        public Room getConnectedRoom(char direction)
        {
            switch (char.ToUpper(direction))
            {
                case 'N':
                    return north;
                case 'E':
                    return east;
                case 'S':
                    return south;
                case 'W':
                    return west;
                default:
                    Console.WriteLine("Invalid direction! Use 'N', 'E', 'S', or 'W'.");
                    return null;
            }
        }
    }
}
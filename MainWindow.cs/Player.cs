using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainWindow.cs
{
    public class Player
    {
        private Room currentRoom;

        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }

        public Room getCurrentRoom()
        {
            return this.currentRoom;
        }

        public bool move(char direction)
        {
            Room nextRoom = this.currentRoom.getConnectedRoom(direction);
            if (nextRoom != null)
            {
                this.currentRoom = nextRoom;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
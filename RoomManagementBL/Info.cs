using RoomManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagementBL
{
    public class Info
    {
        public string name;
        public List<Room> rooms = new List<Room>();
        
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public static void DisplayRoom(Room room)
        {
            Console.WriteLine($"Room Number: {room.roomNo}");
            Console.WriteLine($"Name: {room.name}");
            Console.WriteLine($"Phone Number: {room.phonenum}");
            Console.WriteLine($"Number of People Renting: {room.numRent}");
            Console.WriteLine($"Number of Pets: {room.pets}");
            Console.WriteLine($"With A/C: {room.Ac}");

        }

    }
}

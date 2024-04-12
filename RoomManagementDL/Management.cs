using RoomManagementModel;
using RoomManagementBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagementDL
{
    public class Management
    {
        public static List<Room> rooms = new List<Room>();

        public static void NosRooms()
        {
            Room room1 = new Room();
            room1.roomNo = " 101";
            room1.name = "John Smith";
            room1.phonenum = "09123456789";
            room1.numRent = "3";
            room1.pets = "2";
            room1.Ac = "Yes";
            rooms.Add(room1);

            Room room2 = new Room();
            room2.roomNo = "Room 102";
            room2.name = "Sarah Johnson";
            room2.phonenum = "09145934562";
            room2.numRent = "1";
            room2.pets = "1";
            room2.Ac = "No";
            rooms.Add(room2);

            Room room3 = new Room();
            room3.roomNo = "Room 103";
            room3.name = "Michael Brown";
            room3.phonenum = "09655423655";
            room3.numRent = "4";
            room3.pets = "0";
            room3.Ac = "Yes";
            rooms.Add(room3);

            Room room4 = new Room();
            room4.roomNo = "Room 201";
            room4.name = "Emily Davis";
            room4.phonenum = "09568432568";
            room4.numRent = "5";
            room4.pets = "1";
            room4.Ac = "No";
            rooms.Add(room4);

            Room room5 = new Room();
            room5.roomNo = "Room 202";
            room5.name = "David Wilson";
            room5.phonenum = "09354786255";
            room5.numRent = "2";
            room5.pets = "1";
            room5.Ac = "Yes";
            rooms.Add(room5);

            Room room6 = new Room();
            room6.roomNo = "Room 203";
            room6.name = "Jennifer Taylor";
            room6.phonenum = "09486315678";
            room6.numRent = "1";
            room6.pets = "0";
            room6.Ac = "Yes";
            rooms.Add(room6);

            Room room7 = new Room();
            room7.roomNo = "Room 301";
            room7.name = "James Martinez";
            room7.phonenum = "09564873214";
            room7.numRent = "5";
            room7.pets = "0";
            room7.Ac = "Yes";
            rooms.Add(room7);

            Room room8 = new Room();
            room8.roomNo = "Room 302";
            room8.name = "Jessica Clark";
            room8.phonenum = "09564822647";
            room8.numRent = "4";
            room8.pets = "1";
            room8.Ac = "Yes";
            rooms.Add(room8);

            Room room9 = new Room();
            room9.roomNo = "Room 303";
            room9.name = "Robert Anderson";
            room9.phonenum = "09648257396";
            room9.numRent = "3";
            room9.pets = "2";
            room9.Ac = "Yes";
            rooms.Add(room9);
        }

        public static void RoomList()
        {
            NosRooms();

            Console.WriteLine("\nSelect Room Number");
            Console.WriteLine("1. 101");
            Console.WriteLine("2. 102");
            Console.WriteLine("3. 103");
            Console.WriteLine("4. 201");
            Console.WriteLine("5. 202");
            Console.WriteLine("6. 203");
            Console.WriteLine("7. 301");
            Console.WriteLine("8. 302");
            Console.WriteLine("9. 303");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Info.DisplayRoom(rooms[0]);
                    break;

                case "2":
                    Info.DisplayRoom(rooms[1]);
                    break;

                case "3":
                    Info.DisplayRoom(rooms[2]);
                    break;

                case "4":
                    Info.DisplayRoom(rooms[3]);
                    break;

                case "5":
                    Info.DisplayRoom(rooms[4]);
                    break;

                case "6":
                    Info.DisplayRoom(rooms[5]);
                    break;

                case "7":
                    Info.DisplayRoom(rooms[6]);
                    break;

                case "8":
                    Info.DisplayRoom(rooms[7]);
                    break;

                case "9":
                    Info.DisplayRoom(rooms[8]);
                    break;

                default:
                    Console.WriteLine("INVALID");
                    break;


            }
        }

    }
}

using RoomManagementBL;
using RoomManagementDL;

namespace RoomManagement
{
    public class Program
    {
        static Info rooms = new Info();
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nApartment Room Management");
                Console.WriteLine("1. Information about the Program");
                Console.WriteLine("2. Room List");
                Console.WriteLine("3. Exit");
                Console.WriteLine("\nSelect an Option");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("This program will help you on managing the information of the residents living in your apartment.");
                        Console.WriteLine(" It has the basic and important informations like names, contact numbers, room number, number of people renting, pets and if they have air condions.");
                        break;

                    case "2":
                        Management.RoomList();
                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }

        }

    }

    
}

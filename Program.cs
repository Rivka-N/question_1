//Rivka Nadell 6848
//Rina Greenboim 5948
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            HostingUnit hotel1= new HostingUnit();
            string message = "please enter your choice: \na to book your stay, b to, c to , d to exit\n";
            Console.Write(message);
            char choice = Console.ReadKey().KeyChar;
            while (choice != 'd')//while the choice isn't exit
            {
                try
                {
                    switch (choice)
                    {
                        case 'a':
                            Console.WriteLine("\nenter day and month of stay");
                            int day = Convert.ToInt32(Console.ReadLine());
                            int month = Convert.ToInt32(Console.ReadLine());
                            DateTime date = new DateTime(2020, month, day);
                            Console.WriteLine("how many days is your stay?");
                            int stayLen = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(hotel1.checkDates(date, stayLen) == true ? "Your stay was booked" : "Unnable to book your stay");
                            break;
                        case 'b':
                            break;
                        case 'c':
                            break;
                        case 'd': //exits
                            break;
                        default:
                            Console.WriteLine("invalid choice. Try again\n");
                            break;
                    }
                }
                catch { Console.WriteLine("\nUnexpected error. Try again."); }
                Console.WriteLine(message);
                choice = Console.ReadKey().KeyChar;//recieves a new choice
            }
        }
    }
}
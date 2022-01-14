using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballClubTEC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            // DateTime dateTime = DateTime.Now;
            //Console.SetCursorPosition(100, 0);
            // Console.WriteLine(dateTime.ToString("MMMM dd, yyyy"));
            // Console.WriteLine("");

            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Blue;
            ConsoleColor background = Console.BackgroundColor;
            ConsoleColor foreground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
           


            // Set the Foreground color to red for headline
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WelCome To TEC Ballerup Stadium!");
            Console.WriteLine();
           


            // int numberofmoretickets;
            int numberofadultticket;
            int numberofchildticket;
            //string moretickets = Console.ReadLine();
            int childrenticketcost = 30;
            int adultticketcost = 65;
            double clubmember_discount = 0.1; //(10% discount)
            int total_tickets;
            double ticket_cost = 0;
            string club_member;
            double euro;
            double DKKtoEuro = 757.34;
           
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine("Ballerup Stadium's Tickets and Price: ");
            Console.WriteLine("What is the price of ticket?");
            Console.WriteLine("AdultTicket : {0},  ChildrenTicket : {1} ", adultticketcost, childrenticketcost);

            Console.WriteLine("");


            Console.Write("How many adult tickets would you like to buy? : ");
            numberofadultticket = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many children tickets would you like to buy? : ");
            numberofchildticket = Convert.ToInt32(Console.ReadLine());
            total_tickets = numberofadultticket + numberofchildticket;
            Console.WriteLine("Total number of Tickets {0} ",total_tickets);
            Console.WriteLine("");

            if ((numberofadultticket > 10) || (numberofchildticket > 10))
            {
                Console.WriteLine("You can not make order more than 10 for adult ticket and 10 for children ticket, Please try again");
            }
            Console.WriteLine("");

               Console.WriteLine("Are you a member of the Club's association's group? [YES/NO]");
               club_member = Console.ReadLine();

            if (club_member != "no")
            {
                ticket_cost = ((numberofadultticket * adultticketcost) + (numberofchildticket * childrenticketcost)) * clubmember_discount;
                Console.WriteLine("The total cost of tickets after discount :{0} DKK", ticket_cost);

            }

            else
            {
                ticket_cost = (numberofadultticket * adultticketcost) + (numberofchildticket * childrenticketcost);
                Console.WriteLine("The total cost of the ticket :{0} DKK", ticket_cost);
            }
            Console.WriteLine("Would you like to pay in euro? [YES/NO]");


           
            //string answer = Console.ReadLine();
            //if (answer.ToLower() == "yes")
            //{
            //    if (!File.Exists(myPath)) //Does the file exist
            //    {
            //        File.Create(myPath).Close(); //No, then we create and close it for writing
            //    }
            //    //Let's add the record to the end of the file. Have a look at https://www.w3.org/International/questions/qa-what-is-encoding
            //    File.AppendAllText(myPath, myRecord, Encoding.Unicode);
            //}

            Console.ReadKey();


            //do
            //{
            //    Console.WriteLine("How many adult ticket would you like to buy? : ");
            //    numberofadultticket = Convert.ToInt32(Console.ReadLine());

            //    if (numberofadultticket > 10)
            //    {
            //        Console.WriteLine("Would you like to buy more than 10 adult ticket? : ");
            //    }
            //    while (numberofadultticket > 10)
            //    {
            //        Console.WriteLine("You want to buy {} adult tickets", numberofadultticket);
            //    }

            //    do
            //    {
            //        Console.WriteLine("How many children ticket would you like to buy? : ");
            //        numberofchildticket = Convert.ToInt32(Console.ReadLine());

            //        if (numberofchildticket > 10)
            //        {
            //            Console.WriteLine("Would you like to buy more than 10 adult ticket? : ");
            //        }
            //        while (numberofchildticket > 10)
            //        {
            //            Console.WriteLine("You want to buy {} adult tickets", numberofchildticket);
            //        }
            //console.writeline("")
        }
                






            /*
            Console.WriteLine("Would you like to buy more tickets? [YES/NO]");
            do
            {
                if (moretickets.Equals("Y"))
                {
                    Console.WriteLine("Yes");
                    break;
                }
                else if (moretickets.Equals("N"))
                {
                    Console.WriteLine("No");
                    break;
                }

            } while (moretickets == "N");
            */
            //numberofmoretickets = Convert.ToInt32(Console.ReadLine());



        
    }
}


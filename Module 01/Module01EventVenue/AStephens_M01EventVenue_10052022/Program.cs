/*
 * -----------------------------------------------------------------------
#
##
## Purpose of code:
##  The manager of an event venue wants you to write a program that calculates the total ticket sales after each event. There are four types of tickets:

orchestra ($100)
floor ($75)
tier 1 ($50)
tier 2 ($40)
tier 3 ($35)


The user should be asked for what level do they have tickets and how many. Please note: this program should only accept one type of ticket.



After each event, data is input by the user and then displayed in the following form for recording purposes:
Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Decision statement - that determines what the user entered and will give the price of the ticket.
Proper mathematical calculations
Proper output - so the user can see how much the total of the tickets cost.
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs

-------------------------------------------------------------
##
##
## ---------------------------
##
## Notes:
##  orchestra ($100)
## floor ($75)
## tier 1 ($50)
## tier 2 ($40)
## tier 3 ($35)
##
## ---------------------------
*/

using System;
using System.Diagnostics;

namespace EventVenue
{

    class Tickets
    {
        string? NameTicket;
        int PriceTicket;


        static void Main(string[] args)
        {
            string Input, TicketNumber;

            //Creating Tickets
            Tickets Orchestra = new();
            Orchestra.NameTicket = "Orchestra";
            Orchestra.PriceTicket = 100;

            Tickets Floor = new();
            Floor.PriceTicket = 75;
            Floor.NameTicket = "Floor";

            Tickets Teir1 = new();
            Teir1.PriceTicket = 50;
            Teir1.NameTicket = "Teir 1";

            Tickets Teir2 = new();
            Teir2.PriceTicket = 40;
            Teir2.NameTicket = "Teir 2";

            Tickets Teir3 = new();
            Teir3.PriceTicket = 35;
            Teir3.NameTicket = "Teir 3";


            //Reading User Input
            //Choosing Type Of Ticket
            Console.WriteLine("Please Choose Type Of Ticket:\n" +
                "| 1 - Orchestra || 2 - Floor || 3 - Teir 1 || 4 - Teir 2 || 5 - Teir 3 |\n");
            Input = Console.ReadLine().ToUpper();


            //Chosing Ammount Of Tickets
            Console.WriteLine("How Many Tickets?: \n");

            //ConvertInt
            string inp;
            inp = Console.ReadLine();
            int SoldTickets;
            SoldTickets = Convert.ToInt32(inp);




            //Display
            switch (Input)
            {
                case "1":

                    Console.WriteLine(" Type Of Ticket | " + Orchestra.NameTicket + "\n" +
                                      " Ticket Price   | $" + Orchestra.PriceTicket + "\n" +
                                      " # Number Sold  | " + SoldTickets + "\n" +
                                      " Cost           | $" + SoldTickets * Orchestra.PriceTicket + "\n");


                    break;
                case "2":
                    Console.WriteLine(" Type Of Ticket | " + Floor.NameTicket + "\n" +
                                      " Ticket Price   | $" + Floor.PriceTicket + "\n" +
                                      " # Number Sold  | " + SoldTickets + "\n" +
                                      " Cost           | $" + SoldTickets * Floor.PriceTicket + "\n");
                    break;
                case "3":
                    Console.WriteLine(" Type Of Ticket | " + Teir1.NameTicket + "\n" +
                                      " Ticket Price   | $" + Teir1.PriceTicket + "\n" +
                                      " # Number Sold  | " + SoldTickets + "\n" +
                                      " Cost           | $" + SoldTickets * Teir1.PriceTicket + "\n");
                    break;
                case "4":
                    Console.WriteLine(" Type Of Ticket | " + Teir2.NameTicket + "\n" +
                                      " Ticket Price   | $" + Teir2.PriceTicket + "\n" +
                                      " # Number Sold  | " + SoldTickets + "\n" +
                                      " Cost           | " + SoldTickets * Teir2.PriceTicket + "\n");
                    break;
                case "5":
                    Console.WriteLine(" Type Of Ticket | " + Teir3.NameTicket + "\n" +
                                      " Ticket Price   | $" + Teir3.PriceTicket + "\n" +
                                      " # Number Sold  | " + SoldTickets + "\n" +
                                      " Cost           | $" + SoldTickets * Teir3.PriceTicket + "\n");
                    break;


                    //Would problably work better as a function / Place a function inside functions and run with it. (Setting what Teir was selcted then calling that within a dipslay funciton etc..)

            }

        }
    }
}
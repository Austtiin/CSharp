/*
 * -----------------------------------------------------------------------
# Austin Stephens
1092022

##
## Purpose of code:
##  You have been hired by the Umbrella Corporation to create a sales receipt generator. This generator should be able:

Store customer name, phone number, e-mail address, and address.
Allow the user to enter the products wanted, provide the prices and calculate the final bill.
Customers should be allowed to put in as many products as they wish and as many orders as they wish.
The program should automatically calculate and display the taxes.
There will be two types of customers: tax exempt and those who have to pay taxes.


This program will handle errors and provide good input validation.

You will be altering your code for every module - 
adding/modify the code from the week before to enhance the program’s capabilities and to add functionality as needed. 
You may want to keep copies of your previous weeks work, so that if there is an issue, you can start from scratch.

-------------------------------------------------------------
##
##
##
## ---------------------------
*/

using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace SalesRecGen
{
    class Product
    {

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }
        private static bool Menu()
        {


            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\t\tSales Receipt: ");
            Console.WriteLine("\t\t\t\tInvoice Number: ");
            Console.WriteLine("\t\t\t\tDate: ");
            Console.WriteLine("\t\t\t\tCustomer Name: ");
            Console.WriteLine("\t\t\t\tPrice: ");
            Console.WriteLine("\t\t\t\t --------------------");
            Console.WriteLine("\t\t\t\t Items: ");

            Console.ReadLine();
            return true;


            /*
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("Enter Products");
            Console.WriteLine("Sell An Item");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    
                    return true;
                case "2":
                    
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
            
            */

        }


    }
}

/* private readonly string? CustomerFirst;
private readonly string? CustomerLast;
private readonly string? PhoneNum;
private readonly string? EMail;
private readonly string? Address;
bool TaxExempt;
double TaxRate = 6.5;
*/
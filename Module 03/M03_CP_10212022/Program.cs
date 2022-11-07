/*
 * -----------------------------------------------------------------------
#
##
## Purpose of code:

Altering the course project program from the previous module, add input validation to ensure proper user input. 
Then also error handling to ensure the program will not have any issues with improper data handling.

-------------------------------------------------------------Your program must have the following:

An introductory statement that allows the user to understand what type of program they are running.
Variable declarations
User input acceptance
Proper mathematical calculations
Proper output
You must provide the following:
Your code
Screenshot of your fully functioning program with inputs/outputs
## 
##
## ---------------------------
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace SalesInfo
{
    class Products
    {

        public int? Price { get; set; }
        public string? NameProduct { get; set; }
        public int? ProductId { get; set; }
    }


    class SaleInfo
    {
        public int? NumInvoice;
        public string? NameF;
        public string? NameL;
        public int? NumPhone;
        public int? PurchPrice = 0;
    }


    



    class program
    {
        private static bool test;

        static void Main(string[] args)
        {
            string inp = "";
            Random random = new Random();
            int InventoryCount = 5;
            Products[] Product = new Products[InventoryCount];
            int Recipts = 6;
            SaleInfo[] CustRecipt = new SaleInfo[Recipts];

            for (int i = 0; i < Recipts; i++)
            {
                CustRecipt[i] = new SaleInfo()
                {
                    NumInvoice = NumGen(i + 14, 55),
                    NameF = "Customer",
                    NameL = "No. " + i.ToString(),
                    NumPhone = NumGen(1111, 9999)
                };

            }

            for (int i = 0; i < InventoryCount; i++)
            {

                Product[i] = new Products()
                {
                    ProductId = i,
                    Price = NumGen(1, 500),
                    NameProduct = "Product " + i
                };
            }


            Console.Clear();
            Console.WriteLine("***  Please Choose Customer Number to continue: (1-5) ***");


            for (int i = 1; i < Recipts; i++)
            {
                Console.WriteLine("\n\nInvoice Number: " + CustRecipt[i].NumInvoice);
                Console.WriteLine("          Name: " + CustRecipt[i].NameF + " " + CustRecipt[i].NameL);
                Console.WriteLine(" Phone Number : " + NumGen(111, 999) + "-" + NumGen(111, 999) + "-" + CustRecipt[i].NumPhone);
            }






            //Error handling

            while (test == false)
            {
                try
                {
                    
                    inp = Console.ReadLine();

                    if (inp == "1" || inp == "2" || inp == "3" || inp == "4" || inp == "5")
                    {
                        test = true;
                    }

                    if (test == true)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("USER ERROR ");
                    
                }
                finally
                {
                    Console.WriteLine("Error: Invalid Num | Character");
                    Console.WriteLine("Retry With a Correct Number");
                    
                    
                }
            }


            int CUSNUM = Convert.ToInt32(inp);


            Console.Clear();
            Console.WriteLine("***  Please Choose Product ID's, enter exit to exit ***");

            for (int i = 0; i < InventoryCount; i++)
            {
                Console.WriteLine("\nProduct ID  : " + Product[i].ProductId);
                Console.WriteLine("Product Name: " + Product[i].NameProduct);
                Console.WriteLine("Product Price: " + Product[i].Price);

            }



            
            inp = Console.ReadLine();


            //Input Vali.
            while (string.IsNullOrEmpty(inp))
            {
                Console.WriteLine("Please Enter a Product ID! ");
                inp = Console.ReadLine();
            }
                
        

            int pass = Convert.ToInt32(inp);




            while (inp != "exit")
            {

                CustRecipt[CUSNUM].PurchPrice = Product[pass].Price + CustRecipt[CUSNUM].PurchPrice;
                Console.WriteLine(CustRecipt[CUSNUM].PurchPrice);
                inp = Console.ReadLine();
            }



            static int NumGen(
               int min,
               int max)

            {
                Random random = new Random(); return random.Next(min, max);

            }
        }

        
    }
}


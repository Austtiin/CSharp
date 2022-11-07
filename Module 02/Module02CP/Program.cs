/*
 * -----------------------------------------------------------------------
#
##
## Purpose of code:
Altering the course project program from the previous module, 
use arrays/loops to create a list of products and prices (Minimum of 5) so that, 
instead of entering in the prices, the user can select the items and the costs will 
utomatically be added together. Add the ability to store 3 sets of customer’s basic 
information 
- first name, last name, phone number, sales, etc.
##  

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
        static void Main()
        { 
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

                

                ///////////////////////////////////////////////////////////////////////////////////////
                // Console.WriteLine(Product[1].NameProduct);
                
                
                
                Console.Clear();
                Console.WriteLine("\t\t\tMenu");
                Console.WriteLine("-------------------------------");
             
                //Console.WriteLine("Enter Customers First name: ");
                //CustRecipt[c].NameF = Console.ReadLine();
                //Console.WriteLine("Enter Customers last name: ");

                for(int i = 0; i < Recipts; i++)
                    { 
                    Console.WriteLine("\n\nInvoice Number: " + CustRecipt[i].NumInvoice);
                    Console.WriteLine("          Name: " + CustRecipt[i].NameF + " " + CustRecipt[i].NameL);
                    Console.WriteLine(" Phone Number : " + NumGen(111, 999) + "-" + NumGen(111, 999) + "-" + CustRecipt[i].NumPhone);
                    }
                
                ////////////////////////////////////////////////////////////////////////////////////


                Console.Clear();
                Console.WriteLine("***  Please Choose Customer Number to continue: (1-6) ***");
                 for(int i = 0; i < Recipts; i++)
                 { 
                    Console.WriteLine("\n\nInvoice Number: " + CustRecipt[i].NumInvoice);
                    Console.WriteLine("          Name: " + CustRecipt[i].NameF + " " + CustRecipt[i].NameL);
                    //Console.WriteLine(" Phone Number : " + NumGen(111, 999) + "-" + NumGen(111, 999) + "-" + CustRecipt[i].NumPhone);
                 }

                
                  string inp = Console.ReadLine();
                  int CUSNUM = Convert.ToInt32(inp);

                    Console.Clear();
                    Console.WriteLine("***  Please Choose Product ID's, enter exit to exit ***");
                for(int i = 0; i < InventoryCount; i++)
                 { 
                   Console.WriteLine("\nProduct ID  : " + Product[i].ProductId);
                   Console.WriteLine("Product Name: " + Product[i].NameProduct);
                   Console.WriteLine("Produt Price: " + Product[i].Price);
                    
                 }
           
                inp = Console.ReadLine();
                int pass = Convert.ToInt32(inp);


                while(inp != "exit")
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


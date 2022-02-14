using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naman_and_nattu
{
    internal class Program
    {

        static void withdrawal()
        {  

            Console.Write("Enter the amount you want to withdrawal :  ");
            //Console.WriteLine("");

            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            if (amt > 0 && amt !=0.1)
            {
                Console.WriteLine("wait while we processe your transcation");
                Console.WriteLine("");

                int sleepTime = 10000;
                Task.Delay(sleepTime).Wait();


                Console.WriteLine("Please collect your cash");
                Console.WriteLine("");

                Console.WriteLine("transaction successfull");
                Console.WriteLine("");

                Console.WriteLine("summry of transaction :");
                Console.WriteLine("");

                Console.WriteLine("Amount withdrawal ->"+amt);

            }
            
            else
            {
                Console.WriteLine("You entered invalid input");
            }




        }

        static void deposite ()
        {
            Console.Write("Entert the amount you want to deposit : ");
           // Console.WriteLine("");

            int dep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(dep > 0)
            {
                Console.WriteLine("wait while we process your transaction");
                Console.WriteLine("");

                int sleeptime = 5000;
                Task.Delay(sleeptime).Wait();

                Console.Write("Please place your cash in deposit pocket after placing cash in it press 'Y' for continue : ");
               

                char y = Convert.ToChar(Console.ReadLine());
                if (y == 'Y')
                {
                    Console.WriteLine("");

                    Console.WriteLine("Wait while we process your transcation");
                    Console.WriteLine("");


                    int sleeptime1 = 5000;
                    Task.Delay(sleeptime1).Wait();

                    Console.WriteLine("your cash successfully deposited");
                    Console.WriteLine("");


                    Console.WriteLine("summry of transaction : ");
                    Console.WriteLine("");

                    Console.WriteLine("Amount deposited -> "+ dep);




                }
                else
                {
                    Console.WriteLine("You entered invalid input please collect your cash from deposit pocket and try again to deposit your money");

                }






            }
            else
            {
                Console.WriteLine("You entered invalid input ");

            }
        }






        static void Main(string[] args)
        {
            int A;
            do
            {
                Console.WriteLine("press 1 for withdrawal :");
                Console.WriteLine("");

                Console.WriteLine("press 2 for deposit : ");
                Console.WriteLine("");





                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:

                        withdrawal();

                        break;

                    case 2:

                        deposite();

                        break;


                      
                }
                Console.WriteLine("");
               Console.WriteLine("press 0 to run again the menu");
               A = Convert.ToInt32(Console.ReadLine());


            } while (A == 0);


















































            Console.ReadLine();



        }
    }
}

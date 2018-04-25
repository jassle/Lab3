using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            bool repeat = true;

            Console.WriteLine("Hello! What is your name?");
            name = (Console.ReadLine());
            Console.WriteLine("Hello, " + name);

            while (repeat)
            {
                string userinput;
                int usernum;
                    Console.WriteLine("Please enter a number between 1 and 100:");
                    userinput = (Console.ReadLine());

                    if (!int.TryParse(userinput, out usernum) || 100 < usernum || usernum < 1)
                    {
                        Console.WriteLine("Invalid Entry, Please try again ");

                    continue;
                    }
                    //else
                    //{
                    //    Console.WriteLine("Invalid Entry, Please try again ");
                    //}

                //Convert.ToInt32(userinput);

                if (usernum % 2 == 1)
                {
                    Console.WriteLine(usernum + " Odd");
                }
                else if (25 >= usernum )
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (usernum >= 26 & )
                {
                    Console.WriteLine("Greater than 25 Even");
                }
                else if (usernum > 60)
                {
                    Console.WriteLine("Greater than 60 Even");
                }


                repeat = Continue();
                    //if (input == false)
                    //{
                    //    Console.WriteLine("Goodbye, " + name);
                    //    break;
                    //}
                }

         
            
            Console.WriteLine("Goodbye, " + name);
           

        }

        public static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue?");
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopWhile
{
    internal class Program
    {
        static void Main()
        {
            // calculator of 2 numbers with 
            // (+ - * / )
            // -----------------------------

            // variable to make many calculations
            string strYN;

            do
            {
                // other variables
                int num1;
                int num2;
                string cal;
                int result;

                // aske user to enter 2 numbers
                Console.Write("enter number 1 : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("enter number 2 : ");
                num2 = int.Parse(Console.ReadLine());

                // ask user to enter calculation
                // (+ - * /)
                Console.Write("enter calculation (+ or - or * or / : ");
                cal = Console.ReadLine();
                    if (cal == "+")
                    {
                        result = Convert.ToInt32(num1+num2);
                        Console.WriteLine(result);
                    }
                    else if(cal == "-")
                    {
                        result= Convert.ToInt32(num2-num1);
                        Console.WriteLine(result);
                    }
                    else if(cal == "*")
                    {
                        result = Convert.ToInt32(num1*num2);
                        Console.WriteLine(result);
                }
                    else if(cal == "/")
                    {
                        if (num1 > num2)
                        {
                        result = Convert.ToInt32(num1 / num2);
                        }
                        else
                        {
                        result = Convert.ToInt32(num2 / num1);
                    }
                    Console.WriteLine(result);
                }
                    else
                    {
                    Console.WriteLine("not a valid value, try again");
                    }

                // ask user to make another calculation
                Console.WriteLine("****************");
                Console.Write("do you want another calculation (y/n) : " );
                strYN = Console.ReadLine();
            }   while (strYN == "y" || strYN == "Y");
        }
    }
}

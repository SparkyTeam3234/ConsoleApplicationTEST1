using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTEST1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("What would like to do?  Enter 'S' for Sum, 'F' for Factorial, 'C' for Cash Add.");

            var cmd = Console.ReadLine();

            switch (cmd.ToUpper())
            { 
                case "S":
                    DoMath(cmd);
                    break;
                case "F":
                    DoMath(cmd);
                    break;
                case "C":
                    CashAdd();
                    break;
                default:
                    Console.WriteLine("By By !!");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }


        static void DoMath(string cmd)
        {
            if (cmd.ToUpper() == "F")
            {
                Console.WriteLine("Enter an Integer to Factorial");
                var input = Console.ReadLine();
                int n;
                if (int.TryParse(input.ToString(), out n))
                {
                    int rtrn = MyFactorial(n);

                    Console.WriteLine(n.ToString() + " Factorial is " + rtrn.ToString());
                }
                else
                {
                    Console.WriteLine(input + " is not an Integer");
                    DoMath("F");
                }
            }


            if (cmd.ToUpper() == "S")
            {
                Console.WriteLine("Enter an Integer to Sum");
                var input = Console.ReadLine();
                int n;
                if (int.TryParse(input.ToString(), out n))
                {
                    int rtrn = MySum(n);

                    Console.WriteLine(n.ToString() + " Sum is " + rtrn.ToString());
                }
                else
                {
                    Console.WriteLine(input + " is not an Integer");
                    DoMath("F");
                }

            }

        }


        static void CashAdd()
        {

            double tot = 0;

            double[,] myCash = new double[1000,2];
            int itemCount = 0;

            while (true)
            {

                Console.WriteLine("Enter your Price, or non number to exit and get total");

                var p = Console.ReadLine();

                double pr;


                if (double.TryParse(p.ToString(), out pr))
                {
                    double newpr;

                    myCash[itemCount, 0] = pr;
                    Console.Clear();
                    if (pr > 150)
                    {
                        newpr = (pr * 0.85) * 1.06;
                        Console.WriteLine("Discount(20%): {0:C}", newpr);
                    }
                    else
                    {
                        newpr = pr * 1.06;
                        Console.WriteLine("No Discount: {0:C}", newpr);
                    }
                    tot = tot + newpr;

                    myCash[itemCount, 1] = newpr;

                    Console.WriteLine("");
                    itemCount++;


                    for (int i =0; i< itemCount; i++)
                        Console.WriteLine("Item: {0:C}: {1:C}", myCash[i, 0].ToString() , myCash[i,1]);

                    Console.WriteLine("Your total is: {0:C}", tot);

                }
                else
                {
                    Console.WriteLine("Your done and your total is: {0:C}", tot);
                    break;
                }
            }
        }

        /// <summary>
        /// Finds Factorial of n
        /// </summary>
        /// <param name="n">number to find the factorial</param>
        /// <returns>n!</returns>
        static int MyFactorial(int n)
        {
            int rusult = 1;

            for (int i = 2; i <= n; i++)
                rusult = rusult * i;

            return rusult;

        }
        /// <summary>
        /// Finds 1+2+3...+n
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>1+2+3...+n</returns>
        static int MySum(int n)
        {
            int rusult = 0;

            for (int i = 1; i <= n; i++)
                rusult = rusult + i;

            return rusult;

        }
    }
}

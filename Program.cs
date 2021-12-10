using System;

namespace SamakarnSolver_Lite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("Samagarntunka Solver LITE (Automatic ver.)\n\nThe differences of this ver. is this ver. will find your X value automatically\n\nDisclaimer : Not all answer are correct this is a very poor build console\nDisclaimer2 : this console can only solve within 4 Pahunarm\n\nHow to use : Example 2xgumlung3 - 3xgumlung2 - 7x - 6\nA=2 B=-3 C=-7 D=-6\n\n");


            //asking for input
            Console.WriteLine("Please enter the a value\n");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the b value\n");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the c value\n");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter the d value\n");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press Enter to start the process\n\n");
            Console.ReadLine();


            //Processing
            //Asking for the x

            int X = 1;
            int minusX = -1;
            int firstx = X * X * X;
            int secondx = X * X;
            int Thirdx = X * 1;

            int firstMinusX1 = minusX * minusX * minusX;
            int secondMinusX2 = minusX * minusX;
            int ThirdMinusX3 = minusX * 1;


            int result5 = (a * firstx) + (b * secondx) + (c * Thirdx) + d;
            int result5minus = (a * firstMinusX1) + (b * secondMinusX2) + (c * ThirdMinusX3) + d;
            Console.WriteLine("X = "+ X +" is " + result5 + "\n");
            Console.WriteLine("-X = " + minusX + " is " + result5minus + "\n\n");
            if (result5 != 0 || result5minus != 0) 
            {
                while(result5 != 0)
                {
                    int firstX = X * X * X;
                    int secondX = X * X;
                    int ThirdX = X * 1;

                    int firstMinusX = minusX * minusX * minusX;
                    int secondMinusX = minusX * minusX;
                    int ThirdMinusX = minusX * 1;

                    X++;
                    minusX--;
                    int result4 = (a * firstX) + (b * secondX) + (c * ThirdX) + d;
                    int result4minus = (a * firstMinusX) + (b * secondMinusX) + (c * ThirdMinusX) + d;

                    Console.WriteLine(a + "* " + firstX + " " + b + " * " + secondX + " " + c + " * " + ThirdX + " " + d);

                    Console.WriteLine("X = " + X + " is " + result4 + "\n");
                    Console.WriteLine("-X = " + minusX + " is " + result4minus + "\n\n");
                    if (result4 == 0)
                    {
                        Console.WriteLine("Ans Found : The value of X : " + X + " Succeed to make the result to " + result4 +" (For minus) : " + minusX + " is " + result4minus);

                        Console.WriteLine("\n\nThe loop stop now. Please press enter to end process\n--------------------------------------------------------------------------------------------------------------");
                        break;
                    }
                    if (result4minus == 0)
                    {
                        Console.WriteLine("Ans Found : The value of X : " + X + " Succeed to make the result to " + result4 + " (For minus) : " + minusX + " is " + result4minus);

                        Console.WriteLine("\n\nThe loop stop now. Please press enter to end process\n--------------------------------------------------------------------------------------------------------------");
                        break;
                    }
                }
            }

            Console.WriteLine("\n\n(This is the first ans if your process are in loop please ignore) \n\nAns Found : The value of X : " + X + " Succeed to make the result to " + result5+ " (For minus) : " + minusX + " is " + result5minus);
            Console.WriteLine("\n\nThe loop stop now. Please press enter to end process");
            Console.ReadLine();



        }
    }
}

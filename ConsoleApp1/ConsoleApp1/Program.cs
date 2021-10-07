using System;

namespace ConsoleApp1
{
    class Program
    {


        static double segment1(double x, double r)
        {
            double a = -2;
            double b = 0;
            double y;
            y = Math.Sqrt(r * r - (x - a) * (x - a) - b);
            return y;

        }
        static double segment2(double x, double r)
        {
            double a = 1;
            double b = 0;
            double y;
            y = Math.Sqrt(r * r - (x - a) * (x - a) - b);
            return -y;

        }
        static double segment3()
        {
            double y;
            y = 1;
            return y;
        }
        static double segment4(double x)
        {
            double y;
            y = (-x - 4) / 2;
            return y;
        }
        static double segment5(double x)
        {
            double y;
            y = -x + 2;
            return y;
        }

        static void value_finder(double R1, double R2, double i)
        {

            if (i < -7)
            {
                Console.WriteLine("Function is not defined");
            }
            else if (i < -6)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment3());
            }
            else if (i < -4)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment4(i));
            }
            else if (i < 0)
            {
                if (R1 < 2)
                {
                    Console.WriteLine("breaks occur at these values, please enter another R: ");
                }
                else if (R1 > 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment1(i, 2));
                }
                else if (R1 == 2)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment1(i, 2));
                }
            }
            else if (i < 2)
            {
                if (R2 < 1)
                {
                    Console.WriteLine("breaks occur at these values, please enter another R: ");
                }
                else if (R2 > 1)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment2(i, 1));
                }
                else if (R2 == 1)
                {
                    Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment2(i, 1));
                }

            }
            else if (i <= 3)
            {
                Console.WriteLine("y({0:0.00}) = {1:0.00}", i, segment5(i));
            }
            else if (i > 3)
            {
                Console.WriteLine("function is not defined");
            }
        }



        static void Main(string[] args)
        {

            double R1 = 0;
            double R2 = 0;
            Console.WriteLine("Enter radius of the first circle: ");
            R1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius of the second circle: ");
            R2 = double.Parse(Console.ReadLine());

            if (R1 < 0 || R2 < 0)
            {
                while (R1 < 0 || R2 < 0)
                {

                    Console.WriteLine("R cannot be less than zero, enter again: ");
                    R1 = double.Parse(Console.ReadLine());
                    R2 = double.Parse(Console.ReadLine());
                }

            }



            double in_value = 0;

            while (in_value != 500)
            {
                Console.WriteLine("Enter x (if you want to finish, please click 500): ");
                in_value = double.Parse(Console.ReadLine());
                if (in_value != 500)
                {
                    value_finder(R1, R2, in_value);
                }
            }


            for (double x = -7; x <= 3; x = x + 0.2)
            {
                value_finder(R1, R2, x);
            }
        }
    }
}
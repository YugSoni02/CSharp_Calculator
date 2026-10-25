using System;

namespace calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This Program is designed to calculate the addition , subtraction, Multiplication and Division given by the user");

            Console.WriteLine("Enter the first number for calculation");
            double no1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number for calculation");
            double no2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your choise (A for addition, B for Subtraction, C for Multiplication, D for Division)");
            string inp = Console.ReadLine();

            if (inp == "A" || inp == "a")
            {
                double result = no1 + no2;
                Console.WriteLine("Your Answer is : " + result);
            }
            else if (inp == "B" || inp == "b")
            {
                double result = no1 - no2;
                Console.WriteLine("Your Answer is : " + result);
            }
            else if (inp == "C" || inp == "c")
            {
                double result = no1 * no2;
                Console.WriteLine("Your Answer is : " + result);
            }
            else if (inp == "D" || inp == "d")
            {
                if (no1 != 0 && no2 != 0)
                {
                    double result = no1 / no2;
                    Console.WriteLine("Your Answer is : " + result);
                }
                else
                {
                    Console.WriteLine("Error Cant divide by 0");
                }
            }
        }
    }
}

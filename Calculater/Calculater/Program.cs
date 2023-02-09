using System;
using System.Collections.Generic;
using System.Linq;

namespace HellowCsharp
{
    class Program
    {
        static void Result()
        {
            Console.Write(" The Result is : ");
        }

        static void Main(string[] args)
        {
            //welcome user
            Console.WriteLine(" * welcom to calculator application *\n\n");
            char toend = 'a';
            while (toend != 'N')
            {


                //ask user to enter the first number
                Console.WriteLine(" Please enter the first number");
                double nFirstNumber = 0;
                //check if first number is a valid number
                bool bIsValidNumber = double.TryParse(Console.ReadLine(), out nFirstNumber);
                if (!bIsValidNumber)
                {
                    Console.WriteLine(" Please enter a valid number");
                    return;
                }
                //ask user to enter the second number
                Console.WriteLine(" Please enter the second number");
                double nSecondNumber = 0;
                //check if the second number is a valid number
                bIsValidNumber = double.TryParse(Console.ReadLine(), out nSecondNumber);
                if (!bIsValidNumber)
                {
                    Console.WriteLine(" Please enter a valid number");
                    return;
                }
                //ask user to enter the operator
                Console.WriteLine(" Please enter the operator(+ - * / % ^ )");
                //int Operator = 0;
                //check operator 
                //bIsValidNumber = int.TryParse(Console.ReadLine(),out Operator);
                //if (bIsValidNumber)
                //{
                //    Console.WriteLine("Please enter a valid operator");
                //    return ;

                //}
                char nOperator = Convert.ToChar(Console.ReadLine());

                //perform operator
                switch (nOperator)
                {
                    case '+':
                        Result(); Console.WriteLine(nFirstNumber + nSecondNumber);
                        break;
                    case '-':
                        Result(); Console.WriteLine(nFirstNumber - nSecondNumber);
                        break;
                    case '*':
                        Result(); Console.WriteLine(nFirstNumber * nSecondNumber);
                        break;
                    case '/':
                        Result(); Console.WriteLine(nFirstNumber / nSecondNumber);
                        break;
                    case '%':
                        Result(); Console.WriteLine(nFirstNumber % nSecondNumber);
                        break;
                    case '^':
                        Result(); Console.WriteLine(Math.Pow(nFirstNumber, nSecondNumber));
                        break;
                    default:
                        Console.WriteLine(" Please enter a valid operator");
                        break;

                }
                Console.WriteLine(" \n Do you want to perform any other operation? Y/N");
                toend = Convert.ToChar(Console.ReadLine());
            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an operator ");
                char ope = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter another number ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (ope)
                {
                    case '*':
                        int sum1 = num1 * num2;
                        Console.WriteLine(sum1);
                        break;
                    case '-':
                        int sum2 = num1 - num2;
                        Console.WriteLine(sum2);
                        break;
                    case '+':
                        int sum3 = num1 + num2;
                        Console.WriteLine(sum3);
                        break;
                    case '/':
                        try
                        {
                            int sum4 = num1 / num2;
                            Console.WriteLine(sum4);
                        }
                        catch
                        {
                            Console.WriteLine("UNDIFINED");
                        }
                        break;
                    default:
                        Console.WriteLine("INVALID OPERATOR");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("ENTER AN INTERGER");
            }
            Console.ReadLine();
        }
    }
}

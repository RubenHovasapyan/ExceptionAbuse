using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nominator;
                Console.WriteLine("Please, enter a nominator...");
                bool nomIsValid = Int32.TryParse(Console.ReadLine(), out nominator);
                if (!nomIsValid)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please, enter a number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                    Console.ResetColor();
                }
                else
                {
                    int denominator;
                    Console.WriteLine("Please, enter a denominator...");
                    bool denomIsValid = Int32.TryParse(Console.ReadLine(), out denominator);
                    if (!denomIsValid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please, enter a number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        Console.ResetColor();

                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Denominator cannot be zero!");
                            Console.ResetColor();

                        }
                        else
                        {
                            int result = nominator / denominator;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} / {1} = {2}", nominator, denominator, result);
                            Console.ResetColor();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

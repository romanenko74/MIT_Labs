using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //romanenko_визначення змінних
            double a;
            double b;
            string operation;
            double answer;

            //romanenko_введення даних та вибір операції
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select operation: +, -, *, / ");
            operation = Console.ReadLine();
        }
    }
}

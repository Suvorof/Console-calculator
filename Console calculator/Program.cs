using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            string first_number = Console.ReadLine();
            double first_num = Convert.ToDouble(first_number);

            Console.WriteLine("Введите второе число: ");
            string second_number = Console.ReadLine();
            double second_num = Convert.ToDouble(second_number);

            Console.WriteLine("Введите любой из предложенных математических операторов +, -, *, /: ");
            string sign = Console.ReadLine();

            double result_1 = first_num + second_num;
            double result_2 = first_num - second_num;
            double result_3 = first_num * second_num;
            double result_4 = first_num / second_num;

            switch (sign)
            {
                case "+":
                    Console.WriteLine(result_1);
                    break;
                case "-":
                    Console.WriteLine(result_2);
                    break;
                case "*":
                    Console.WriteLine(result_3);
                    break;
                case "/":
                    if (second_num == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно");
                    }
                    else
                    {
                        Console.WriteLine(result_4);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Смоделируйте работу простого калькулятора. 
             * Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
             * После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.    */



            
            Console.Write("Введите 1 число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число ");
            int b = Convert.ToInt32(Console.ReadLine());
            char z;
            Console.WriteLine("Введите  код операции :");
            Console.WriteLine("1 : сложение");
            Console.WriteLine("2 : вычитание");
            Console.WriteLine("3 : произведение");
            Console.WriteLine("4 : частное");

            z = Console.ReadKey().KeyChar;
            Console.WriteLine();



            switch (z)
            {
                case '1':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '2':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '3':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;

                case '4':
                    try
                    {
                        Console.WriteLine("{0}/{1}={2}", a, b, a / b);

                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Деление на ноль !");
                    }


                    break;
                default:
                    Console.WriteLine("Ошибка. Введен неправильный код операции ");
                    break;



            }



            Console.ReadKey();
        }



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Programm
    {
        static void Main(string[] args)
        {
            Start:
            
            Console.WriteLine("Введите первое значение");
            string x = Console.ReadLine();
            decimal a;
            
                if (decimal.TryParse(x, out a))
                {
                    goto Second;
                }
                {
                    Console.WriteLine("Неверный параметр '{0}'. Повторите ввод", x);
                    goto Start;
                }
                    
                
            Second:
            
            Console.WriteLine("Введите второе значение");
            string y = Console.ReadLine();
            decimal b;
            
                if (decimal.TryParse(y, out b))
                {
                goto Operator;
                }
                {
                Console.WriteLine("Неверный параметр '{0}'. Повторите ввод", y);
                goto Second;
                }
                
            Operator:
            
            Console.WriteLine("Введите действие (+, - , *, /)");
            string z = Console.ReadLine();
            
            switch (z)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Неверный символ. Укажите действие заново");
                    goto Operator;
            }
            
            Question:
            
            Console.WriteLine("Провести другой расчёт? y/n");
            string t = Console.ReadLine();

            switch (t)
            {
                case "y":
                    goto Start;
                case "n":
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Пожалуйста, укажите значение y или n");
                    goto Question;
            }
            Console.ReadKey();
        }
    }
     
}


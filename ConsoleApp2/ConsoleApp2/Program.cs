using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float dollar = 0.011369f;
            float rub = 87.96f;

            float userConvertInput;

            Console.WriteLine("Добро пожаловать в обмен валют");

            Console.Write("Сколько у вас рублей? ");
            float rubToDollar = Convert.ToSingle(Console.ReadLine());
            Console.Write("Хорошо. Сколько у вас долларов? ");
            float dollarToRub = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Окей. У вас есть {rubToDollar} рублей и {dollarToRub} долларов");
            Console.WriteLine("");
            Console.WriteLine("Как хотите конвертировать свою валюту? ");
            Console.WriteLine("1. Рубли в Доллары");
            Console.WriteLine("2. Доллары в Рубли");
            Console.Write("Выбор операции: ");

            string choosingAnOperation = Console.ReadLine();

            switch (choosingAnOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей в доллары");
                    Console.Write("Сколько вы хотите обменять? ");
                    userConvertInput = Convert.ToSingle(Console.ReadLine());
                    if (rubToDollar >= userConvertInput)
                    {
                        rubToDollar -= userConvertInput;
                        dollarToRub += userConvertInput * dollar;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;

                case "2":
                    Console.WriteLine("Обмен долларов в рубли");
                    Console.Write("Сколько вы хотите обменять? ");
                    userConvertInput = Convert.ToSingle(Console.ReadLine());
                    if (dollarToRub >= userConvertInput)
                    {
                        dollarToRub -= userConvertInput;
                        rubToDollar += userConvertInput * rub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                    break;
                    default:
                    Console.WriteLine("Такой оперции не существует"); 
                        break;
            }

            Console.WriteLine($"Конвертация прошла успешно.Теперь у вас на счету {rubToDollar} рублей и {dollarToRub} долларов!");
            Console.ReadKey();





        }
    }
}

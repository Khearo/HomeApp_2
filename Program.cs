using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp_2 // Lesson #2 by Aleksandr K
{
    class Program
    {
        static void Main()
        {
            sumOddNumber(); // Сумма нечетных положительных чисел.


            Digits();  // Количество цифр.

            CheckLogPass();  // Проверка логина и пароля.

            BMI();          // ИМТ с информацией о весе.

            minNumber();  // Минимальное число из 3х введенных. */

        }

        private static void sumOddNumber()
        {
            int sum = 0;
            int number = 0;


            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 == 1)
                    sum = sum + number;

            } while (number != 0);

            Console.WriteLine($"Сумма чисел: {sum}");
            Console.ReadKey();
        }

          private static void Digits()
             {
                  Console.WriteLine(" Подсчет количества цифр введенного числа: ");

                  Console.Write("Введите число: ");
                  int number = int.Parse(Console.ReadLine());

                  int count = 0;

                  while (number > 0)
                  {
                      count++;
                      number = number / 10;
                  }

                  Console.WriteLine($"Количество цифр введенного числа : {count}");

                  Console.ReadKey();

          }

             private static void CheckLogPass()
             {
                 int count = 0;

                 do
                 {
                     Console.WriteLine("  Введите логин: ");
                     string log = Console.ReadLine();

                     Console.WriteLine("  Введите пароль: ");
                     string pass = Console.ReadLine();

                     if (log == "root" && pass == "GeekBrains")
                     {
                         Console.WriteLine("  Добро пожаловать!");
                         break;
                     }
                     else
                     {
                         Console.WriteLine("  Пожалуйсте введите верные данные! ");
                         count++;
                         Console.WriteLine($"Доступный лимит попыток: 3. Количество ваших попыток: {count}");
                     }
                 }
                 while (count < 3);

                 Console.ReadKey();
             }

             private static void BMI()
             {
                 Console.WriteLine("Добро пожаловать в программу по расчету ИМТ (индекс массы тела) :");

                 Console.Write("Введите ваш рост в метрах: ");
                 double h = double.Parse((Console.ReadLine()));

                 Console.Write("Введите ваш вес в килограммах: ");
                 double m = double.Parse((Console.ReadLine()));

                 double i = m / (h * h);

                 Console.WriteLine($"Ваш ИМТ: {i:0.00}");

                 if (i < 16)
                 {
                     Console.Write("У вас дефицит массы тела. Вам нужно набрать вес.");
                 }
                 else if (i >= 18 && i <= 25)
                 {
                     Console.Write("Ваша масса тела в норме.");
                 }
                 else if (i >= 26)
                 {
                     Console.Write("У вас избыточная масса тела. Вам нужно похудеть.");
                 }

                 Console.ReadKey();
             }

             private static void minNumber()
             {

                 Console.WriteLine("Найдем минимальное число из 3х введенных: ");

                 int min;

                 Console.Write("Введите первое число: ");
                 int a = int.Parse(Console.ReadLine());

                 Console.Write("Введите второе число: ");
                 int b = int.Parse(Console.ReadLine());

                 Console.Write("Введите третье число: ");
                 int c = int.Parse(Console.ReadLine());

                 if (a < b && a < c)
                 {
                     min = a;
                 }

                 else if  (b < c)
                 {
                     min = b;
                 }

                 else 
                 {
                     min = c;
                 }

                 Console.WriteLine($" Минимальное число: {min}");

                 Console.ReadKey();
             } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint4.Task6.V15.Lib;

namespace Tyuiu.BrukhovAA.Sprint4.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #4                                                              *");
            Console.WriteLine("* Тема: Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #15                                                            *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан строковый массив данных: 'Чикаго', 'Хьюстон'', 'Феникс',           *");
            Console.WriteLine("*'Филадельфия', 'Сан - Антонио', 'Сан - Диего', 'Даллас'. используя класс*");
            Console.WriteLine("* Array подсчитайте количество элементов, длина которых меньше 7.        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            var mass = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= mass.Length - 1; i++)
            {
                Console.WriteLine(mass[i]);
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            int res = ds.Calculate(mass);
            Console.WriteLine("Количество элементов, длина которых меньше 7: ");
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}

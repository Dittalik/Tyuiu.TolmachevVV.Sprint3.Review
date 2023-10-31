using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint3.Review.V11.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Review.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #3                                                                *");
            Console.WriteLine("*Задание Review                                                           *");
            Console.WriteLine("*Вариант #11                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = -5;
            Console.WriteLine("значения от -5 до 5                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   f(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i <= service1.GetMassFunction(-5, 5).Length - 1; i++)
            {
                if (x > 2)
                {
                    Console.WriteLine("|{0,5:d}     |  {1, 5:f2}  |", x, service1.GetMassFunction(-5, 5)[i]);
                    x++;
                }
                else
                Console.WriteLine("|{0,5:d}     |   {1, 5:f2}  |", x, service1.GetMassFunction(-5, 5)[i]);
                x++;
            }
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}

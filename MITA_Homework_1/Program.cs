using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace MITA_Homework_1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем Вас в нашем Зоомагазине!");
            Console.WriteLine("Укажите возраст питомца:");
            var colour = new CatColour("Белый", "Зеленый");
            var MyLittleKitty = new Cat(Console.ReadLine(), colour);
            int cls = 0;
            while (cls != 5)
            {
                Helper.ChangeConsoleColour(MyLittleKitty.CheckCurColour());
                Console.WriteLine($"Питомец:{MyLittleKitty.Name}");
                Console.WriteLine($"Возраст:{MyLittleKitty.Age}");
                Console.WriteLine($"Текущий цвет:{MyLittleKitty.CheckCurColour()}");

                Console.WriteLine("1 - Задать имя;" + "\n" + "2 - Задать цвет;" + "\n" + "3 - Покормить;" + "\n" +
                                  "4 - Ударить;" + "\n" + "5 - Выход;");
                cls = Convert.ToInt32((Console.ReadLine()));
                switch (cls)
                {
                    case 1:
                    {
                        Console.WriteLine("Введите имя питомца:");
                        MyLittleKitty.Name = Console.ReadLine();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Доступные цвета:" + "\n" + "Ж - Жёлтый;" + "\n" + "К - Красный;" + "\n" +
                                          "С - Синий;" + "\n" + "П - Пурпурный;" + "\n" + "Б - Белый;" + "\n" +
                                          "З - Зелёный;" + "\n");

                        Console.WriteLine("Желаемый цвет здорового кота:");
                        MyLittleKitty.Colour.HealthColour = Console.ReadLine();
                        Console.WriteLine("Цвет кота в болезненном состоянии:");
                        MyLittleKitty.Colour.SickColour = Console.ReadLine();
                        break;
                    }
                    case 3:
                    {
                        MyLittleKitty.Feed();
                        break;
                    }
                    case 4:
                    {
                        MyLittleKitty.Punish();
                        break;
                    }
                    case 5:
                    {
                        break;
                    }
                }
               }

        }
        
        

    }

    public abstract class Helper
    {
        public static void ChangeConsoleColour(string col)
        {
            col = col.ToUpper();
            switch (col[0])
            {
                case 'Ж':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 'К':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 'С':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 'П':
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 'Б':
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 'З':
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
        }

    }
}

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
            var myLittleKitty = new Cat(colour, Console.ReadLine());
            int cls = 0;
            while (cls != 5)
            {
                if (myLittleKitty.CurrentColour == colour.HealthColour)
                {
                    Helper.ChangeConsoleColour(myLittleKitty.CurrentColour, 1);
                }
                else
                {
                    Helper.ChangeConsoleColour(myLittleKitty.CurrentColour, 0);
                }
                Console.WriteLine($"Питомец:{myLittleKitty.Name}");
                Console.WriteLine($"Возраст:{myLittleKitty.Age}");
                Console.WriteLine($"Текущий цвет:{myLittleKitty.CurrentColour}");

                Console.WriteLine("1 - Задать имя;" + "\n" + "2 - Задать цвет;" + "\n" + "3 - Покормить;" + "\n" +
                                  "4 - Ударить;" + "\n" + "5 - Выход;");

                cls = Convert.ToInt32((Console.ReadLine()));
                switch (cls)
                {
                    case 1:
                      Console.WriteLine("Введите имя питомца:");
                      myLittleKitty.Name = Console.ReadLine();
                        break;
                    
                    case 2:
                        Console.WriteLine("Доступные цвета:" + "\n" + "Ж - Жёлтый;" + "\n" + "К - Красный;" + "\n" +
                                          "С - Синий;" + "\n" + "П - Пурпурный;" + "\n" + "Б - Белый;" + "\n" +
                                          "З - Зелёный;" + "\n");

                        Console.WriteLine("Желаемый цвет здорового кота:");
                        myLittleKitty.Colour.HealthColour = Console.ReadLine();
                        Console.WriteLine("Цвет кота в болезненном состоянии:");
                        myLittleKitty.Colour.SickColour = Console.ReadLine();
                        break;
                    
                    case 3:
                    myLittleKitty.Feed();
                        break;
                    
                    case 4:
                        myLittleKitty.Punish();
                        break;
                    
                    case 5:
                    break;
                    
                }
               }

        }
        
        

    }

    public abstract class Helper
    {
        public static void ChangeConsoleColour(string col, int rslt)
        {
            col = col.ToUpper();
            if (col != "Ж" && col != "К" && col != "С" && col != "П" && col != "Б" && col != "З")
            {
                if (rslt == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else
            {
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
}

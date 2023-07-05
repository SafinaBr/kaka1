using System;

namespace SafinaLearn
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inWork = true;
            while (inWork)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Введите номер темы:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(1) 1.1 - Условные конструкции");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("(2) 1.2 - Циклы");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(3) 1.3 - Массивы");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(4) 2.1 - Перегрузка операторов");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("(5) 2.2 - Перегрузка операций преобразования типов");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("(6) 2.3 - Обобщения");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("(7) 2.4 - Индексаторы");
                Console.WriteLine("-----------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                var glovalOption = Console.ReadLine();
                switch (glovalOption)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Red;
                        ConditionalConstructionsMenu();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        CyclesMenu();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "5":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "6":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "7":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Неверное значение, хотите выйти? y/n");
                        var choose = Console.ReadLine();
                        if (choose == "y")
                        {
                            inWork = false;
                        }
                        break;
                }

                
            }
        }
        
        public static void ConditionalConstructionsMenu()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Введите номер задания (1-7)");
            var taskOption = Console.ReadLine();
            switch (taskOption)
            {
                case "1":
                    ConditionalConstructions.Start.Task1();
                    break;
                case "2":
                    ConditionalConstructions.Start.Task2();
                    break;
                case "3":
                    ConditionalConstructions.Start.Task3();
                    break;
                case "4":
                    ConditionalConstructions.Start.Task4();
                    break;
                case "5":
                    ConditionalConstructions.Start.Task5();
                    break;
                case "6":
                    ConditionalConstructions.Start.Task6();
                    break;
                case "7":
                    ConditionalConstructions.Start.Task7();
                    break;
                default:
                    break;
            }
            Console.WriteLine("-----------------------------------------");
        }
        public static void CyclesMenu()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Введите номер задания (1-4)");
            var taskOption = Console.ReadLine();
            switch (taskOption)
            {
                case "1":
                    Cycles.Start.Task1();
                    break;
                case "2":
                    Cycles.Start.Task2();
                    break;
                case "3":
                    Cycles.Start.Task3();
                    break;
                case "4":
                    Cycles.Start.Task4();
                    break;
                default:
                    break;
            }
            Console.WriteLine("-----------------------------------------");
        }

    }
}
﻿using System;

namespace SafinaLearn.ConditionalConstructions
{
    public static class Start
    {/// <summary>
     /// Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).
     /// </summary>
        public static void Task1()
        {
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int a = Convert.ToInt32(Console.ReadLine());
            if (x == a)
            {
                Console.WriteLine("Два числа равны");
            }
            if (x > a)
            {
                Console.WriteLine("Первое число большего второго");
            }
            if (x < a)
            {
                Console.WriteLine("Первое число меньше второго");
            }
        }
        /// <summary>
        /// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("введите число:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 5 && x < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        /// <summary>
        /// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".
        /// </summary>
        public static void Task3()
        {
            Console.WriteLine("введите число:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 5 || x == 10)
            {
                Console.WriteLine("Число либо равно 5, либо равно 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        /// <summary>
        /// В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
        /// Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("введите сумму вклада:");
            double summaVklada = Convert.ToDouble(Console.ReadLine());
            if (summaVklada < 100)
            {
                summaVklada = summaVklada * 1.05;
            }
            if (summaVklada >= 100 && summaVklada <= 200)
            {
                summaVklada = summaVklada * 1.07;
            }
            if (summaVklada > 200)
            {
                summaVklada = summaVklada * 1.1;
            }
            Console.WriteLine($"Результат: {summaVklada}");

        }
        /// <summary>
        /// Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
        /// </summary>
        public static void Task5()
        {
            Console.WriteLine("введите сумму вклада:");
            double summaVklada = Convert.ToDouble(Console.ReadLine());
            if (summaVklada < 100)
            {
                summaVklada = summaVklada * 1.05;
            }
            if (summaVklada >= 100 && summaVklada <= 200)
            {
                summaVklada = summaVklada * 1.07;
            }
            if (summaVklada > 200)
            {
                summaVklada = summaVklada * 1.1;
            }
            summaVklada = summaVklada + 15;
            Console.WriteLine($"Результат: {summaVklada}");


        }
        /// <summary>
        /// Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
        /// Для определения операции по введенному номеру используйте конструкцию switch...case.
        /// Если введенное пользователем число не соответствует никакой операции(например, число 120), то выведите пользователю сообщение о том, что операция неопределена.
        /// </summary>
        public static void Task6()
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("Oперация неопределена");
                    break;

            }
        }
        /// <summary>
        /// Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.
        /// </summary>
        public static void Task7()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine(x + y);
                    break;
                case 2:
                    Console.WriteLine(x - y);
                    break;
                case 3:
                    Console.WriteLine(x * y);
                    break;
                default:
                    Console.WriteLine("Oперация неопределена");
                    break;

            }

        }
    }
}

//Console.WriteLine("Введите x");
//string inputX = Console.ReadLine();
//Console.WriteLine("Введите y");
//string inputY = Console.ReadLine();
//int x = Convert.ToInt32(inputX);
//int y = Convert.ToInt32(inputY);

//if ( x == 30 && x == 50 )
//{
//    Console.WriteLine("30 и 50");
//}

//if ( x > 30 || x < 15)
//{
//    Console.WriteLine("x больше 30 или меньще 15");
//}
//if ((x <= 10 || x > 20) && x != 15 )
//{
//    Console.WriteLine("(x меньше или равно 10 или больше 20) и x не равно 15");
//}
//if ((x < y) || (x < 20 && x > 10 && y > 10) && x != 0 && y != 0)
//{
//    Console.WriteLine("(X меньше Y) или (X меньше 20 и больше 10 и Y больше 10) и X не равно 0 и Y не равно 0");
//}

//switch (x)
//{
//    case 30:
//        Console.WriteLine("мама по попе даст");
//        break;
//    case 50:
//        Console.WriteLine("куда тебе такой старик");
//        break;
//    default:
//        Console.WriteLine("не попал");
//        break;
//}

//if (x > 50)
//{
//    Console.WriteLine("МНЕ БОЛЬШЕ 50 АЛО");
//}
//else if (x > 30)
//{
//    Console.WriteLine("то вам попа от мамы");
//}
//else
//{
//    Console.WriteLine("нормик");
//}
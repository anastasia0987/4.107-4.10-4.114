using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class Mainclass
{
    public static void Main()
    {
        int year, month, day, vis, test;
        year = 0;
        month = 0;
        day = 0;
        vis = 0;
        test = 0;
        Console.WriteLine("Какой сейчас год?");
        year = int.Parse(Console.ReadLine());
        if (year > 0)
        {
            Console.WriteLine("Какой сейчас месяц? (порядковый номер)");
            month = int.Parse(Console.ReadLine());
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Год високосный? 1) Да; 2) Нет");
                        vis = int.Parse(Console.ReadLine());
                        if (vis == 1)
                        {
                            Console.WriteLine("Какое сейчас число? (от 1 до 29)");
                            day = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Какое сейчас число? (от 1 до 28)");
                            day = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Какое сейчас число? (от 1 до 30)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Какое сейчас число? (от 1 до 30)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Какое сейчас число? (от 1 до 30)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("Какое сейчас число? (от 1 до 30)");
                        day = int.Parse(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("Какое сейчас число? (от 1 до 31)");
                        day = int.Parse(Console.ReadLine());
                        break;
                }
                if (day >= 1 && day <= 31)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Дата: {day}.{month}.{year}");
                    Console.WriteLine("");
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        if (day == 31)
                        {
                            if (month == 12)
                            {
                                Console.WriteLine($"Завтрашняя дата: 1.1.{year + 1}; вчерашняя дата: 30.{month}.{year}");
                            }
                            else
                            {
                                Console.WriteLine($"Завтрашняя дата: 1.{month + 1}.{year}; вчерашняя дата: 30.{month}.{year}");
                            }
                        }
                        else if (day == 1)
                        {
                            test = month - 1;
                            if (test == 4 || test == 6 || test == 9 || test == 11)
                            {
                                Console.WriteLine($"Завтрашняя дата: 2.{month}.{year}; вчерашняя дата: 30.{month - 1}.{year}");
                            }
                            else if (test == 7)
                            {
                                Console.WriteLine($"Завтрашняя дата: 2.{month}.{year}; вчерашняя дата: 31.{month - 1}.{year}");
                            }
                            else if (test == 0)
                            {
                                Console.WriteLine($"Завтрашняя дата: 2.{month}.{year}; вчерашняя дата: 31.12.{year - 1}");
                            }
                            else if (test == 2)
                            {
                                if (vis == 1)
                                {
                                    Console.WriteLine($"Завтрашняя дата: 2.{month}.{year}; вчерашняя дата: 29.{month - 1}.{year}");
                                }
                                else if (vis == 2)
                                {
                                    Console.WriteLine($"Завтрашняя дата: 2.{month}.{year}; вчерашняя дата: 28.{month - 1}.{year}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Завтрашняя дата: {day + 1}.{month}.{year}; вчерашняя дата: {day - 1}.{month}.{year}");
                        }
                    }
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        if (day == 30)
                        {
                            Console.WriteLine($"Завтрашняя дата: 1.{month + 1}.{year}; вчерашняя дата: 29.{month}.{year}");
                        }
                        else if (day == 1)
                        {
                            test = month - 1;
                            if (test == 4 || test == 6 || test == 9 || test == 11)
                            {
                                Console.WriteLine($"Завтрашняя дата: 2.{month}.{year}; вчерашняя дата: 31.{month - 1}.{year}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Завтрашняя дата: {day + 1}.{month}.{year}; вчерашняя дата: {day - 1}.{month}.{year}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
        }
        else
        {
            Console.WriteLine("Неверные данные");
        }
    }
}